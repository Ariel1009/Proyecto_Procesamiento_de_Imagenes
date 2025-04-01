using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using Emgu.CV;
using System.Drawing.Imaging;
using AForge.Imaging.Filters;
using System.Runtime.InteropServices;
using Emgu.CV.Structure;

namespace Procesamiento_IMG_Proy
{
    public partial class Form3 : Form
    {
        private Bitmap original;
        private Bitmap resultante;
        private int[] histograma = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int anchoV, altoV;
        bool wasPictureLoaded = false;
        private bool HayDispositivos;
        bool EstaGrabando = false;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCam;
        VideoCapture Capturadora;
        bool EstaActivo = false;
        int TotalFrames;
        int CurrentFrameNo;
        Mat CurrentFrame;
        int FPS;
        int filtro = 0;
        public Color color;
        static readonly CascadeClassifier cascade = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        Font drawFont = new Font("Arial", 30);
        SolidBrush drawBrush = new SolidBrush(Color.White);
        StringFormat drawFormat = new StringFormat();
        //AForge.Imaging.Filters.Dilatation ;
        Dilatation filter = new Dilatation();   

        public Form3()
        {
            InitializeComponent();
        }

        private void BTN_BACK_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            Form1 form= new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        public void CargarDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < MisDispositivos.Count; i++)
                    CB_Dispositivos.Items.Add(MisDispositivos[i].Name.ToString());

                CB_Dispositivos.Text = MisDispositivos[0].ToString();
            }
            else
            {
                HayDispositivos = false;
            }
        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> emguImage = Imagen.ToImage<Bgr, byte>();
            int persona = 0;
            Rectangle[] rectangles = cascade.DetectMultiScale(emguImage, 1.2, 1);
            string title = "Persona ";

            foreach (Rectangle rectangle in rectangles)
            {
                persona++;
                using (Graphics graphics = Graphics.FromImage(Imagen))
                {
                    using (Pen pen = new Pen(Color.Aquamarine, 3))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                        graphics.DrawString((title + persona).ToString(), drawFont, drawBrush, rectangle, drawFormat);
                    }
                }
            }
            PB_IMAGES.Image = Imagen;
            original = Imagen;
            resultante = Imagen;
        }

        private void BTN_ACTIVARCAM_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            int i = CB_Dispositivos.SelectedIndex;
            string cam = MisDispositivos[i].MonikerString;
            MiWebCam = new VideoCaptureDevice(cam);
            MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            MiWebCam.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CargarDispositivos();
        }

        private void BTN_SUBIRIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            cerrarWebCam();
            ofd.Filter = "Video Files (*.mp4, *.flv)| *.mp4;*.flv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Capturadora = new VideoCapture(ofd.FileName);
                TotalFrames = Convert.ToInt32(Capturadora.Get(Emgu.CV.CvEnum.CapProp.FrameCount));
                FPS = Convert.ToInt32(Capturadora.Get(Emgu.CV.CvEnum.CapProp.Fps));
                EstaActivo = true;
                CurrentFrame = new Mat();
                CurrentFrameNo = 0;
                PlayVideo();
            }
        }

        private void BTN_FILTROS_Click(object sender, EventArgs e)
        {
            if (Panel_Filtros.Visible == false)
            {
                Panel_Filtros.Visible = true;
            }
            else
            {
                Panel_Filtros.Visible = false;
            }
        }

        public void cerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }

        private void BTN_PLAY_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            if (Capturadora != null)
            {
                EstaActivo = true;
                PlayVideo();
            }

            else
            {
                EstaActivo = false;
            }
        }

        private void BTN_STOP_Click(object sender, EventArgs e)
        {
            EstaActivo = false;
            CurrentFrameNo = 0;
            Capturadora.Set(Emgu.CV.CvEnum.CapProp.PosFrames, CurrentFrameNo);
            Capturadora.Read(CurrentFrame);
            PB_IMAGES.Image = CurrentFrame.ToBitmap();
            resultante = CurrentFrame.ToBitmap();
            PB_IMAGES.Invalidate();
        }

        private void BTN_PAUSE_Click(object sender, EventArgs e)
        {
            EstaActivo = false;
        }

        private async void PlayVideo()
        {
            cerrarWebCam();
            if (Capturadora == null)
            {
                return;
            }

            try
            {
                while (EstaActivo == true && CurrentFrameNo < TotalFrames)
                {
                    Capturadora.Set(Emgu.CV.CvEnum.CapProp.PosFrames, CurrentFrameNo);
                    Capturadora.Read(CurrentFrame);
                    PB_IMAGES.Image = CurrentFrame.ToBitmap();
                    if (resultante == null)
                    {
                        resultante = new Bitmap(PB_IMAGES.Image);
                    }
                    else
                    {
                        resultante = (Bitmap)PB_IMAGES.Image;
                    }
                    switch (filtro)
                    {
                        case 1:
                            if (resultante != null) //dilatacion
                                PB_IMAGES.Image = FiltrosVideo.FiltroDilatacion.Apply(resultante);
                            break;
                        case 2:
                            if (resultante != null) //HistoEq
                              PB_IMAGES.Image = FiltrosVideo.FiltroHistogram.Apply(resultante); 
                            break;
                        case 3:
                            if (resultante != null)//Negativo
                                negativeProcess();  
                            break;
                        case 4:
                            if (resultante != null)//mosaico
                                PB_IMAGES.Image = FiltrosVideo.FiltroPixel.Apply(resultante);
                            break;
                        case 5:
                            if (resultante != null) //Contraste
                                PB_IMAGES.Image = FiltrosVideo.FiltroContraste.Apply(resultante);
                            break;
                        case 6:
                            if (resultante != null) //ACromatica
                                chromaticAberrationProcess();
                            break;
                        case 7:
                            if (resultante != null) //Gamma
                                PB_IMAGES.Image = FiltrosVideo.FiltroGamma.Apply(resultante);
                            break;
                        case 8:
                            if (resultante != null) //Mirror
                                PB_IMAGES.Image = FiltrosVideo.FiltroMirror.Apply(resultante);
                            break;
                        case 9:
                            if (resultante != null) //Otsu
                                PB_IMAGES.Image = FiltrosVideo.OtsuThresholding(resultante);
                            break;
                        case 10:
                            if (resultante != null) //SaltPepper
                                PB_IMAGES.Image = FiltrosVideo.FiltroSalt.Apply(resultante);
                            break;
                        default: break;
                    }
                    CurrentFrameNo += 1;
                    await Task.Delay(1000 / FPS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_NEGATIVO_Click(object sender, EventArgs e)
        {
            filtro = 3;
        }

        private void BTN_MOSAICO_Click(object sender, EventArgs e)
        {
            filtro = 4;
        }

        private void BTN_OTSU_Click(object sender, EventArgs e)
        {
            filtro = 9;
        }

        private void BTN_SALT_Click(object sender, EventArgs e)
        {
            filtro = 10;
        }

        

        private void BTN_STOPCAM_Click(object sender, EventArgs e)
        {
            EstaGrabando = false;
            cerrarWebCam();
            PB_IMAGES.Image = null;
        }

        private void BTN_FDILATACION_Click(object sender, EventArgs e)
        {
            filtro = 1;
        }

        private void BTN_HISTOEQ_Click(object sender, EventArgs e)
        {
            filtro = 2;
        }

        private void BTN_CONTRASTE_Click(object sender, EventArgs e)
        {
            filtro = 5;
        }

        private void BTN_ABERRACION_Click(object sender, EventArgs e)
        {
           filtro = 6;
        }

        private void BTN_GAMMA_Click(object sender, EventArgs e)
        {
            filtro = 7;
        }

        private void BTN_MIRROR_Click(object sender, EventArgs e)
        {
            filtro = 8;
        }

        private async void negativeProcess()
        {

            unsafe
            {
                BitmapData bitmapData = resultante.LockBits(new Rectangle(0, 0, resultante.Width, resultante.Height), ImageLockMode.ReadWrite, resultante.PixelFormat);

                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(resultante.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInPixels = bitmapData.Width * bytesPerPixel;

                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;

                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInPixels; x += bytesPerPixel)
                    {
                        int blue = currentLine[x];
                        int green = currentLine[x + 1];
                        int red = currentLine[x + 2];

                        currentLine[x] = (byte)(255 - blue);
                        currentLine[x + 1] = (byte)(255 - green);
                        currentLine[x + 2] = (byte)(255 - red);
                    }
                });

                resultante.UnlockBits(bitmapData);
            }
            this.Invalidate();
        }

        private async void chromaticAberrationProcess()
        {
            unsafe
            {
                BitmapData bitmapData = resultante.LockBits(new Rectangle(0, 0, resultante.Width, resultante.Height), ImageLockMode.ReadWrite, resultante.PixelFormat);

                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(resultante.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInPixels = bitmapData.Width * bytesPerPixel;

                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;

                int a = 20;

                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInPixels; x += bytesPerPixel)
                    {
                        int blue;
                        int red;

                        if (x + a < widthInPixels)
                        {
                            blue = currentLine[x + a];
                            red = currentLine[x + a + 2];
                        }
                        else
                        {
                            blue = currentLine[x];
                            red = currentLine[x + 2];
                        }

                        int green = currentLine[x + 1];


                        currentLine[x] = (byte)(blue);
                        currentLine[x + 1] = (byte)(green);
                        currentLine[x + 2] = (byte)(red);
                    }
                });

                resultante.UnlockBits(bitmapData);
            }
        }
        //----Fin de Codigo

    }
}
