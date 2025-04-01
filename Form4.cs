using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesamiento_IMG_Proy
{
    public partial class Form4 : Form
    {
        private Bitmap original;
        private Bitmap resultante;
        //Matrices para el histograma y para editar con matrices de 3x3
        private int[] histograma = new int[256];
        private int[] histogramaG = new int[256];
        private int[] histogramaB = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int mayor;

        public void resetHistograms(Bitmap newImage)
        {
            this.resultante = newImage;
            this.makeHistogram();
        }

        public Form4 (Bitmap editada, Bitmap original)
        {
            InitializeComponent();
            this.original = original;
            this.resultante = editada;
        }

        private void makeHistogram()
        {
            int x = 0;
            int y = 0;

            Color rColor = new Color();

            for (x = 0; x < resultante.Width; x++)
            {
                for (y = 0; y < resultante.Height; y++)
                {
                    rColor = resultante.GetPixel(x, y);
                    histograma[rColor.R]++;
                    histogramaG[rColor.G]++;
                    histogramaB[rColor.B]++;
                }
            }

            int n = 0;

            FindBiggest(histograma);
            FindBiggest(histogramaG);
            FindBiggest(histogramaB);

            P_HistoRojo.Invalidate();
            P_HistoAzul.Invalidate();
            P_HistoVerde.Invalidate();
        }

        private void FindBiggest(int[] hist)
        {
            mayor = 0;
            int n = 0;

            for (n = 0; n < 256; n++)
            {
                if (hist[n] > mayor)
                {
                    mayor = hist[n];
                }
            }

            for (n = 0; n < 256; n++)
            {
                hist[n] = (int)((float)hist[n] / (float)mayor * 156.0f);
            }
        }

        private void PaintHist(object sender, PaintEventArgs e, int[] hist, int opcion)
        {
            int n = 20;
            int altura = 0;
            Graphics g = e.Graphics;
            Pen plumaH = new Pen(Color.Black);
            Pen plumaEjes = new Pen(Color.Black);
            switch (opcion)
            {
                case 1:
                    plumaH = new Pen(Color.Red);
                    break;
                case 2:
                    plumaH = new Pen(Color.Green);
                    break;
                case 3:
                    plumaH = new Pen(Color.Blue);
                    break;
                default: break;
            }

            g.DrawLine(plumaEjes, 19, 171, 277, 171);
            g.DrawLine(plumaEjes, 19, 170, 19, 14);

            for (n = 0; n < 256; n++)
            {
                g.DrawLine(plumaH, n + 20, 170, n + 20, 170 - hist[n]);
            }
        }

        private void P_HistoRojo_Paint(object sender, PaintEventArgs e)
        {
            PaintHist(sender, e, histograma, 1);
        }

        private void P_HistoVerde_Paint(object sender, PaintEventArgs e)
        {
            PaintHist(sender, e, histograma, 2);
        }

        private void P_HistoAzul_Paint(object sender, PaintEventArgs e)
        {
            PaintHist(sender, e, histograma, 3);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            makeHistogram();
            this.Invalidate();
        }
    }
}
