using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Procesamiento_IMG_Proy
{
    internal class FiltrosImage
    {
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

        public static Bitmap Dilation(Bitmap image, int se_dim)
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

            int o = (se_dim - 1) / 2;
            for (int i = o; i < w - o; i++)
            {
                for (int j = o; j < h - o; j++)
                {
                    int position = i * 3 + j * image_data.Stride;
                    for (int k = -o; k <= o; k++)
                    {
                        for (int l = -o; l <= o; l++)
                        {
                            int se_pos = position + k * 3 + l * image_data.Stride;
                            for (int c = 0; c < 3; c++)
                            {
                                result[se_pos + c] = Math.Max(result[se_pos + c], buffer[position]);
                            }
                        }
                    }
                }
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

        public static Bitmap GaussianNoise(Bitmap image)
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

            byte[] noise = new byte[bytes];
            double[] gaussian = new double[256];
            int std = 20;
            Random rnd = new Random();
            double sum = 0;
            for (int i = 0; i < 256; i++)
            {
                gaussian[i] = (double)((1 / (Math.Sqrt(2 * Math.PI) * std)) * Math.Exp(-Math.Pow(i, 2) / (2 * Math.Pow(std, 2))));
                sum += gaussian[i];
            }

            for (int i = 0; i < 256; i++)
            {
                gaussian[i] /= sum;
                gaussian[i] *= bytes;
                gaussian[i] = (int)Math.Floor(gaussian[i]);
            }

            int count = 0;
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < (int)gaussian[i]; j++)
                {
                    noise[j + count] = (byte)i;
                }
                count += (int)gaussian[i];
            }

            for (int i = 0; i < bytes - count; i++)
            {
                noise[count + i] = 0;
            }

            noise = noise.OrderBy(x => rnd.Next()).ToArray();

            for (int i = 0; i < bytes; i++)
            {
                result[i] = (byte)(buffer[i] + noise[i]);
            }

            Bitmap result_image = new Bitmap(w, h);
            BitmapData result_data = result_image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, result_data.Scan0, bytes);
            result_image.UnlockBits(result_data);
            return result_image;
        }

        public static Bitmap ImpulseNoise(Bitmap resultante)
        {
            int w = resultante.Width;
            int h = resultante.Height;

            BitmapData image_data = resultante.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            resultante.UnlockBits(image_data);

            Random rnd = new Random();
            int noise_chance = 10;
            for (int i = 0; i < bytes; i += 3)
            {
                int max = (int)(1000 / noise_chance);
                int tmp = rnd.Next(max + 1);
                for (int j = 0; j < 3; j++)
                {
                    if (tmp == 0 || tmp == max)
                    {
                        int sorp = tmp / max;
                        result[i + j] = (byte)(sorp * 255);
                    }
                    else
                    {
                        result[i + j] = buffer[i + j];
                    }
                }
            }

            Bitmap result_image = new Bitmap(w, h);
            BitmapData result_data = result_image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, result_data.Scan0, bytes);
            result_image.UnlockBits(result_data);

            return result_image;
        }

    }
}
