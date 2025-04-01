using AForge.Video;
using AForge.Imaging;
using AForge.Imaging.Filters;
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
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Procesamiento_IMG_Proy
{
    public partial class Form2 : Form
    {
        private Bitmap original;
        private Bitmap resultante;
        //private int[] histograma = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int anchoV, altoV;
        bool wasPictureLoaded = false;
        bool EstaGrabando = false;
        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCam;
        Form4 HistogramsW;
        SeleccionadorColor SeleccionadorColor;
        ColorGradiente ColorGradiente;
        //FiltrosImage filtros;
        public Color color;
        public Color color1;
        public Color color2;

        public Form2()
        {
            InitializeComponent();

            resultante = new Bitmap(658, 502);

            anchoV = 658;
            altoV = 502;
        }



        private void BTN_BACK_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            Form1 form1 = new Form1();

            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void BTN_BAJARIMG_Click(object sender, EventArgs e)
        {
            save_image();
        }



        private void Form2_Paint(object sender, PaintEventArgs e)
        {

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

        private void BTN_SUBIRIMG_Click(object sender, EventArgs e)
        {
            charge_image();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarDispositivos();
        }



        private void BTN_ACTIVARCAM_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            int i = CB_Dispositivos.SelectedIndex;
            string cam = MisDispositivos[i].MonikerString;
            
                MiWebCam = new VideoCaptureDevice(cam);
                MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
                MiWebCam.Start();
                EstaGrabando = true;
         

        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            PB_IMAGES.Image = Imagen;
        }

        private void BTN_HISTOGRAMA_Click(object sender, EventArgs e)
        {
            if (HistogramsW == null)
            {
                HistogramsW = new Form4(resultante, original);
            }
            if (EstaGrabando)
            {
                MessageBox.Show("Detenga la cámara o tome una foto para ver los histogramas");
            }
            else
            {
                HistogramsW.Show();
            }
        }

        private void BTN_DESCCAM_Click(object sender, EventArgs e)
        {
            EstaGrabando = false;
            cerrarWebCam();
            PB_IMAGES.Image = null;
        }



        private void BTN_FOTO_Click(object sender, EventArgs e)
        {
            MiWebCam.NewFrame += new NewFrameEventHandler(Fotografia);
            EstaGrabando = false;
        }

        private void Bright_Slide_ValueChanged(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            Color cNuevo = new Color();
            Color cOriginal = new Color();

            //Variables para gaurdar rgb original
            int r = 0;
            int g = 0;
            int b = 0;


            Bitmap brightness = new Bitmap(resultante);


            double shine = Bright_Slide.Value * 0.1;

            for (x = 0; x < brightness.Width; x++)
            {
                for (y = 0; y < brightness.Height; y++)
                {

                    cOriginal = brightness.GetPixel(x, y);
                    r = (int)(cOriginal.R * shine);
                    g = (int)(cOriginal.G * shine);
                    b = (int)(cOriginal.B * shine);


                    if (r > 255)
                    {
                        r = 255;
                    }
                    if (r <= 0)
                    {
                        r = 0;
                    }

                    if (g > 255)
                    {
                        g = 255;
                    }
                    if (g <= 0)
                    {
                        g = 0;
                    }

                    if (b > 255)
                    {
                        b = 255;
                    }
                    if (b <= 0)
                    {
                        b = 0;
                    }

                    cNuevo = Color.FromArgb(r, g, b);

                    brightness.SetPixel(x, y, cNuevo);
                }
            }

            PB_IMAGES.Image = brightness;
            this.Invalidate();
            if (HistogramsW != null)
            {
                HistogramsW.resetHistograms(resultante);
            }
        }

        private void save_image()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultante.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void Fotografia(object sender, NewFrameEventArgs e)
        {
            Bitmap image = (Bitmap)e.Frame.Clone();
            PB_IMAGES.Image = image;
            original = image;
            resultante = original;
            Console.WriteLine(original);
            if (original != null)
            {
                wasPictureLoaded = true;
                if (HistogramsW != null)
                {
                    HistogramsW.resetHistograms(resultante);
                }

            }
            cerrarWebCam();
        }
        public void cerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
                PB_IMAGES = null;
            }
        }

        private bool charge_image()
        {
            cerrarWebCam();
            openFileDialog1.Filter = "Image Files (*.png, *.jpg, *.jpeg)| *.jpeg;*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                anchoV = original.Width;
                altoV = original.Height;

                resultante = original;
                PB_IMAGES.SizeMode = PictureBoxSizeMode.Zoom;
                PB_IMAGES.Image = original;
                wasPictureLoaded = true;
                if (HistogramsW != null)
                {
                    HistogramsW.resetHistograms(resultante);
                }
                this.Invalidate(); //forza el evento de paint para que se dibuje la imagen.
            }
            return wasPictureLoaded;
        }

        private async void BTN_FCOLOREAR_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            if (original == null)
            {
                wasPictureLoaded = charge_image();
                PB_IMAGES.Refresh();
            }

            if (wasPictureLoaded)
            {
                SeleccionadorColor = new SeleccionadorColor();
                SeleccionadorColor.ShowDialog();
                if (!SeleccionadorColor.color.IsEmpty)
                {
                    color = SeleccionadorColor.color;

                    Task graying = new Task(grayProcess);
                    graying.Start();
                    await graying;
                    PB_IMAGES.Refresh();
                    Task colorize = new Task(colorizeProcess);
                    colorize.Start();
                    await colorize;

                    if (HistogramsW != null)
                    {
                        HistogramsW.resetHistograms(resultante);
                    }
                }
                else
                {
                    PB_IMAGES.Refresh();
                }
            }
        }

        private async void BTN_GRADIENTE_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            if (original == null)
            {
                wasPictureLoaded = charge_image();
                PB_IMAGES.Refresh();
            }

            if (wasPictureLoaded)
            {
                ColorGradiente = new ColorGradiente();
                ColorGradiente.ShowDialog();
                if (!ColorGradiente.color1.IsEmpty && !ColorGradiente.color2.IsEmpty)
                {

                    Task graying = new Task(grayProcess);
                    graying.Start();
                    await graying;

                    PB_IMAGES.Refresh();

                    Task colorGradient = new Task(colorGradientProcess);
                    colorGradient.Start();
                    await colorGradient;

                    if (HistogramsW != null)
                    {
                        HistogramsW.resetHistograms(resultante);
                    }
                }
                else
                {
                    PB_IMAGES.Refresh();
                }
            }
        }

        private async void BTN_NEGATIVO_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            if (original == null)
            {
                wasPictureLoaded = charge_image();
                PB_IMAGES.Refresh();
            }

            if (wasPictureLoaded)
            {

                Task negative = new Task(negativeProcess);
                negative.Start();
                await negative;

                if (HistogramsW != null)
                {
                    HistogramsW.resetHistograms(resultante);
                }
            }
        }

        private async void BTN_CONTRASTE_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            if (original == null)
            {
                wasPictureLoaded = charge_image();
                PB_IMAGES.Refresh();
            }

            if (wasPictureLoaded)
            {
               
                Task contrast = new Task(contrastProcess);
                contrast.Start();
                await contrast;
                
                if (HistogramsW != null)
                {
                    HistogramsW.resetHistograms(resultante);
                }
            }
        }

        private async void BTN_MOSAICO_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            if (original == null)
            {
                wasPictureLoaded = charge_image();
                PB_IMAGES.Refresh();
            }

            if (wasPictureLoaded)
            {

                Task chroma = new Task(pixelateProcess);
                chroma.Start();
                await chroma;

                if (HistogramsW != null)
                {
                    HistogramsW.resetHistograms(resultante);
                }
            }
        }

        private async void BTN_GAUSSIAN_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            if (original == null)
            {
                wasPictureLoaded = charge_image();
                PB_IMAGES.Refresh();
            }

            if (wasPictureLoaded)
            {

                PB_IMAGES.Image = FiltrosImage.GaussianNoise(original);

                if (HistogramsW != null)
                {
                    HistogramsW.resetHistograms(resultante);
                }
            }
        }

        private void BTN_SALT_Click(object sender, EventArgs e)
        {

            cerrarWebCam();
            if (original == null)
            {
                wasPictureLoaded = charge_image();
                PB_IMAGES.Refresh();
            }

            if (wasPictureLoaded)
            {


                //resultante = ImpulseNoise(original);
                PB_IMAGES.Image = FiltrosImage.ImpulseNoise(original);

                if (HistogramsW != null)
                {
                    HistogramsW.resetHistograms(resultante);
                }
            }
        }

        private async void BTN_MIDPOINT_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            if (original == null)
            {
                wasPictureLoaded = charge_image();
                PB_IMAGES.Refresh();
            }

            if (wasPictureLoaded)
            {

                PB_IMAGES.Image = FiltrosImage.OtsuThresholding(original);

                if (HistogramsW != null)
                {
                    HistogramsW.resetHistograms(resultante);
                }
            }
        }

        private void BTN_QPhillips_Click(object sender, EventArgs e)
        {

            if (wasPictureLoaded)
            {

                PB_IMAGES.Image = FiltrosImage.Dilation(original, 15);

                if (HistogramsW != null)
                {
                    HistogramsW.resetHistograms(resultante);
                }
            }
        }

        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            PB_IMAGES.Image = original;
            resultante = original;
            Bright_Slide.Value = 10;
            if (HistogramsW != null)
            {
                HistogramsW.resetHistograms(resultante);
            }
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

        public void pixelateProcess()
        {
            int x = 0;
            int y = 0;
            int mosaico = 8; //La cantidad de pixeles a tomar para el mosaico (8x8)
            int xm = 0;
            int ym = 0;

            resultante = new Bitmap(original.Width, original.Height);

            Color cNuevo = new Color();
            Color cOriginal = new Color();

            //Variables para guardar las sumatorias de los colores
            int rs = 0;
            int gs = 0;
            int bs = 0;

            int r = 0;
            int g = 0;
            int b = 0;

            //resultante = (Bitmap)pbox_imageS.Image;

            for (x = 0; x < original.Width - mosaico; x += mosaico)
            {
                for (y = 0; y < original.Height - mosaico; y += mosaico)
                {
                    //Limpiar variables
                    rs = 0;
                    gs = 0;
                    bs = 0;

                    //Obtener promedio rgb del mosaico
                    for (xm = x; xm < (x + mosaico); xm++)
                    { //Estamos recorriendo cada elemento del mosaico
                        for (ym = y; ym < (y + mosaico); ym++)
                        {//Obtenemos el pixel en el que estamos y se lo sumamos a la sumatoria
                            cOriginal = original.GetPixel(xm, ym);
                            rs += cOriginal.R;
                            gs += cOriginal.G;
                            bs += cOriginal.B;
                        }
                    }
                    //Sacamos el promedio diviendo la sumatoria entre el total de elementos del mosaico
                    r = rs / (mosaico * mosaico);
                    g = gs / (mosaico * mosaico);
                    b = bs / (mosaico * mosaico);

                    //Le ponemos el promedio en el color nuevo
                    cNuevo = Color.FromArgb(r, g, b);

                    //Dibujar el mosaico
                    for (xm = x; xm < (x + mosaico); xm++)
                    {//Recorremos cada elemento del mosaico
                        for (ym = y; ym < (y + mosaico); ym++)
                        {//Le ponemos el mismo color a todos
                            resultante.SetPixel(xm, ym, cNuevo);
                        }
                    }
                }
            }
            PB_IMAGES.Image = resultante;
            this.Invalidate();
        }

        private async void grayProcess()
        {
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            float g = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);
                    g = oColor.R * 0.299f + oColor.G * 0.587f + oColor.B * 0.114f;
                    rColor = Color.FromArgb((int)g, (int)g, (int)g);
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        private async void colorizeProcess()
        {
            int x = 0;
            int y = 0;

            double rc = color.R / 255.0;
            double gc = color.G / 255.0;
            double bc = color.B / 255.0;

            Color miColor = new Color();
            int r = 0;
            int g = 0;
            int b = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    miColor = resultante.GetPixel(x, y);
                    r = (int)(miColor.R * rc);
                    g = (int)(miColor.G * gc);
                    b = (int)(miColor.B * bc);

                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            this.Invalidate();
            PB_IMAGES.Image = resultante;

        }

        
        public void contrastProcess()
        {
            int x = 0;
            int y = 0;

            Color cNuevo = new Color();
            Color cOriginal = new Color();

            //Variables para gaurdar rgb original
            float r = 0;
            float g = 0;
            float b = 0;


            Bitmap contrast = new Bitmap(resultante);

            int contraste = 3 * 3;

            float c = (100.0f + contraste) / 100.0f;
            c *= c;

            for (x = 0; x < contrast.Width; x++)
            {
                for (y = 0; y < contrast.Height; y++)
                {

                    cOriginal = contrast.GetPixel(x, y);
                    r = ((((cOriginal.R / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    g = ((((cOriginal.G / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    b = ((((cOriginal.B / 255.0f) - 0.5f) * c) + 0.5f) * 255;


                    if (r > 255)
                    {
                        r = 255;
                    }
                    if (r < 0)
                    {
                        r = 0;
                    }

                    if (g > 255)
                    {
                        g = 255;
                    }
                    if (g < 0)
                    {
                        g = 0;
                    }

                    if (b > 255)
                    {
                        b = 255;
                    }
                    if (b < 0)
                    {
                        b = 0;
                    }

                    cNuevo = Color.FromArgb((int)r, (int)g, (int)b);

                    contrast.SetPixel(x, y, cNuevo);
                }
            }
            PB_IMAGES.Image = contrast;
            resultante = contrast;
            this.Invalidate();
        }

        private void negativeProcess()
        {
            int x = 0;
            int y = 0;
            Color rColor = new Color();
            Color oColor = new Color();
            resultante = new Bitmap(original.Width, original.Height);

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);
                    rColor = Color.FromArgb(255 - oColor.R,
                                            255 - oColor.G,
                                            255 - oColor.B);
                    resultante.SetPixel(x, y, rColor);
                }

            }
            PB_IMAGES.Image = resultante;
            this.Invalidate();
        }

        

        

        private async void colorGradientProcess()
        {
            color1 = ColorGradiente.color1;
            color2 = ColorGradiente.color2;
            float r1 = color1.R;
            float g1 = color1.G;
            float b1 = color1.B;
            float r2 = color2.R;
            float g2 = color2.G;
            float b2 = color2.B;
            float dr = (r2 - r1) / original.Width;
            float dg = (g2 - g1) / original.Width;
            float db = (b2 - b1) / original.Width;

            int x;
            int y;
            int r = 0;
            int g = 0;
            int b = 0;

            Color oColor;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = resultante.GetPixel(x, y);
                    r = (int)((r1 / 255.0f) * oColor.R);
                    g = (int)((g1 / 255.0f) * oColor.G);
                    b = (int)((b1 / 255.0f) * oColor.B);

                    if (r > 255)
                        r = 255;
                    else if (r < 0)
                        r = 0;
                    if (g > 255)
                        g = 255;
                    else if (g < 0)
                        g = 0;
                    if (b > 255)
                        b = 255;
                    else if (b < 0)
                        b = 0;

                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));
                  
                }


                r1 += dr;
                g1 += dg;
                b1 += db;

            }
            
            PB_IMAGES.Image = resultante;
            this.Invalidate();
        }



    }
}
