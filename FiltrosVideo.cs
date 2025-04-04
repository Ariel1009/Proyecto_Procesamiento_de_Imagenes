﻿using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace Procesamiento_IMG_Proy
{
    internal class FiltrosVideo
    {
        //AForge.Imaging.Filters.
        public static Dilatation FiltroDilatacion = new Dilatation();//

        public static HistogramEqualization FiltroHistogram = new HistogramEqualization();  //

        public static GammaCorrection FiltroGamma = new GammaCorrection();  

        public static SaltAndPepperNoise FiltroSalt = new SaltAndPepperNoise();

        

        public static Pixellate FiltroPixel = new Pixellate();

        public static Mirror FiltroMirror = new Mirror(false, true);

        public static ContrastCorrection FiltroContraste = new ContrastCorrection();

        public static Bitmap OtsuThresholding(Bitmap image)
        {
            int w = image.Width;
            int h = image.Height;

            BitmapData image_data = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];

            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            image.UnlockBits(image_data);

            //Get histogram values
            double[] histogram = new double[256];
            for (int i = 0; i < bytes; i += 3)
            {
                histogram[buffer[i]]++;
            }

            //Normalize histogram
            histogram = histogram.Select(x => (x / (w * h))).ToArray();

            //Global mean
            double mg = 0;
            for (int i = 0; i < 255; i++)
            {
                mg += i * histogram[i];
            }

            //Get max between-class variance
            double bcv = 0;
            int threshold = 0;
            for (int i = 0; i < 256; i++)
            {
                double cs = 0;
                double m = 0;
                for (int j = 0; j < i; j++)
                {
                    cs += histogram[j];
                    m += j * histogram[j];
                }

                if (cs == 0)
                {
                    continue;
                }

                double old_bcv = bcv;
                bcv = Math.Max(bcv, Math.Pow(mg * cs - m, 2) / (cs * (1 - cs)));

                if (bcv > old_bcv)
                {
                    threshold = i;
                }
            }

            for (int i = 0; i < bytes; i++)
            {
                result[i] = (byte)((buffer[i] > threshold) ? 255 : 0);
            }

            Bitmap res_img = new Bitmap(w, h);
            BitmapData res_data = res_img.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, res_data.Scan0, bytes);
            res_img.UnlockBits(res_data);

            return res_img;
        }

        //public static Convolution convolution = new Convolution();
    }
}
