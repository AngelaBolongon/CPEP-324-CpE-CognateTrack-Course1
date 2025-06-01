using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Enhancer
{
    internal class Rgbbox
    {
        public static void RGB(PictureBox pictureBox1, PictureBox pictureBox2, TrackBar trackBarRed, TrackBar trackBarGreen, TrackBar trackBarBlue)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            // Image width and height 
            int width = bmp.Width;
            int height = bmp.Height;

            // Adjust color on taskbar
            double redValue = (double)trackBarRed.Value / 100.0;
            double greenValue = (double)trackBarGreen.Value / 100.0;
            double blueValue = (double)trackBarBlue.Value / 100.0;


            // Amplification factor to increase the effect of the trackbar values
            double amplificationFactor = 5.5; // Adjust this value as needed

            // Modify each pixel in the image
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Get the color of the current pixel
                    Color p = bmp.GetPixel(x, y);

                    // Calculate the new red, green, and blue values based on the trackbar values
                    int newRed = (int)(p.R + (redValue * amplificationFactor * 255));
                    int newGreen = (int)(p.G + (greenValue * amplificationFactor * 255));
                    int newBlue = (int)(p.B + (blueValue * amplificationFactor * 255));

                    // Ensure each channel stays within the 0-255 range
                    newRed = Math.Max(0, Math.Min(255, newRed));
                    newGreen = Math.Max(0, Math.Min(255, newGreen));
                    newBlue = Math.Max(0, Math.Min(255, newBlue));

                    // Set the new color of the pixel
                    bmp.SetPixel(x, y, Color.FromArgb(p.A, newRed, newGreen, newBlue));
                }
            }

            // Display the modified image in the pictureBox
            pictureBox2.Image = bmp;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

    }
   
}
