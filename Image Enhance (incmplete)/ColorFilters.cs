using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_Enhancer
{
    internal class ColorFilters
    {
        // Convert the image to grayscale
        internal Bitmap Greyscale(Bitmap filterImage)
        {
            Bitmap grayscaleBitmap = new Bitmap(filterImage.Width, filterImage.Height);

            for (int x = 0; x < filterImage.Width; x++)
            {
                for (int y = 0; y < filterImage.Height; y++)
                {
                    Color originalColor = filterImage.GetPixel(x, y);
                    int grayValue = (int)(originalColor.R * 0.3 + originalColor.G * 0.59 + originalColor.B * 0.11);
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    grayscaleBitmap.SetPixel(x, y, grayColor);
                }
            }

            return grayscaleBitmap;
        }
        // Convert it to Black & White (Binary Thresholding)
        internal Bitmap BlackAndWhite(Bitmap filterImage, int threshold = 128)
        {
            Bitmap bwBitmap = new Bitmap(filterImage.Width, filterImage.Height);

            for (int x = 0; x < filterImage.Width; x++)
            {
                for (int y = 0; y < filterImage.Height; y++)
                {
                    Color originalColor = filterImage.GetPixel(x, y);
                    int grayValue = (int)(originalColor.R * 0.3 + originalColor.G * 0.59 + originalColor.B * 0.11);

                    //If pixel is above threshold, set to white; otherwise, set to black
                    Color bwColor = (grayValue >= threshold) ? Color.White : Color.Black;
                    bwBitmap.SetPixel(x, y, bwColor);
                }
            }

            return bwBitmap;
        }
        // Convert image to Strawberry Pink
        internal Bitmap PinkFilter(Bitmap filterImage)
        {
            Bitmap pinkBitmap = new Bitmap(filterImage.Width, filterImage.Height);

            for (int x = 0; x < filterImage.Width; x++)
            {
                for (int y = 0; y < filterImage.Height; y++)
                {
                    Color originalColor = filterImage.GetPixel(x, y);

                    int r = Clamp(originalColor.R + 60);
                    int g = Clamp(originalColor.G - 10);
                    int b = Clamp(originalColor.B + 30);

                    pinkBitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return pinkBitmap;
        }
        private int Clamp(int value) // Limits the range value for the filter
        {
            return Math.Max(0, Math.Min(255, value));
        }
        // Convert image to Antique Filter
        internal Bitmap Antique(Bitmap filterImage)
        {
            Bitmap antiqueBitmap = new Bitmap(filterImage.Width, filterImage.Height);
            for (int x = 0; x < filterImage.Width; x++)
            {
                for (int y = 0; y < filterImage.Height; y++)
                {
                    Color originalColor = filterImage.GetPixel(x, y);
                    int r = (int)(originalColor.R * 0.393 + originalColor.G * 0.769 + originalColor.B * 0.189);
                    int g = (int)(originalColor.R * 0.349 + originalColor.G * 0.686 + originalColor.B * 0.168);
                    int b = (int)(originalColor.R * 0.272 + originalColor.G * 0.534 + originalColor.B * 0.131);
                    antiqueBitmap.SetPixel(x, y, Color.FromArgb(Clamp(r), Clamp(g), Clamp(b)));
                }
            }
            return antiqueBitmap;
        }
        // Convert to Cinematic Filter
        internal Bitmap CinematicFilter(Bitmap filterImage)
        {
            Bitmap cinematicBitmap = new Bitmap(filterImage.Width, filterImage.Height);

            for (int x = 0; x < filterImage.Width; x++)
            {
                for (int y = 0; y < filterImage.Height; y++)
                {
                    Color originalColor = filterImage.GetPixel(x, y);

                    //Increase the contrast
                    int r = Clamp((int)((originalColor.R - 128) * 1.2 + 128));
                    int g = Clamp((int)((originalColor.G - 128) * 1.1 + 128));
                    int b = Clamp((int)((originalColor.B - 128) * 1.3 + 128));

                    //Apply teal & orange effect
                    r = Clamp(r + 20); //Pampaboost sa warm tones
                    b = Clamp(b + 10); //Pampaboost sa cool tones

                    //Vignette effect sa edges
                    double distanceX = (x - filterImage.Width / 2.0) / (filterImage.Width / 2.0);
                    double distanceY = (y - filterImage.Height / 2.0) / (filterImage.Height / 2.0);
                    double vignetteFactor = 1 - (distanceX * distanceX + distanceY * distanceY) * 0.2; //Adjust sa intensity

                    r = Clamp((int)(r * vignetteFactor));
                    g = Clamp((int)(g * vignetteFactor));
                    b = Clamp((int)(b * vignetteFactor));

                    cinematicBitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return cinematicBitmap;
        }
        // Convert to Invert Color
        internal Bitmap Invert(Bitmap filterImage)
        {
            Bitmap invertedBitmap = new Bitmap(filterImage.Width, filterImage.Height);
            for (int x = 0; x < filterImage.Width; x++)
            {
                for (int y = 0; y < filterImage.Height; y++)
                {
                    Color originalColor = filterImage.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                    invertedBitmap.SetPixel(x, y, invertedColor);
                }
            }
            return invertedBitmap;
        }
        //Tint Function for ColorFilters
        private Bitmap ApplyColorTint(Bitmap filterImage, int rBoost, int gBoost, int bBoost)
        {
            Bitmap tintedBitmap = new Bitmap(filterImage.Width, filterImage.Height);

            for (int x = 0; x < filterImage.Width; x++)
            {
                for (int y = 0; y < filterImage.Height; y++)
                {
                    Color originalColor = filterImage.GetPixel(x, y);

                    int r = Clamp(originalColor.R + rBoost);
                    int g = Clamp(originalColor.G + gBoost);
                    int b = Clamp(originalColor.B + bBoost);

                    tintedBitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return tintedBitmap;
        }
        // Cyan Tint
        internal Bitmap CyanTint(Bitmap filterImage)
        {
            return ApplyColorTint(filterImage, 0, 50, 50);
        }
        // Green Tint
        internal Bitmap GreenTint(Bitmap filterImage)
        {
            return ApplyColorTint(filterImage, 0, 50, 0);
        }
        // Red Tint
        internal Bitmap RedTint(Bitmap filterImage)
        {
            return ApplyColorTint(filterImage, 60, 0, 0);
        }
        // Blue Tint
        internal Bitmap BlueTint(Bitmap filterImage)
        {
            return ApplyColorTint(filterImage, 0, 0, 50);
        }
        //Yellow Tint 
        internal Bitmap YellowTint(Bitmap filterImage)
        {
            return ApplyColorTint(filterImage, 50, 50, 0);
        }
        //Purple Tint 
        internal Bitmap PurpleTint(Bitmap filterImage)
        {
            return ApplyColorTint(filterImage, 40, 0, 60);
        }

        // Adjust Opacity
        internal Bitmap AdjustOpacity(Bitmap filterImage, float opacity)
        {
            Bitmap adjustedBitmap = new Bitmap(filterImage.Width, filterImage.Height);
            using (Graphics g = Graphics.FromImage(adjustedBitmap))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity / 100f; // Convert opacity to 0-1 range
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix);
                g.DrawImage(filterImage, new Rectangle(0, 0, filterImage.Width, filterImage.Height),
                            0, 0, filterImage.Width, filterImage.Height, GraphicsUnit.Pixel, attributes);
            }
            return adjustedBitmap;
        }
        // Adjust Saturation
        internal Bitmap AdjustSaturation(Bitmap filterImage, float saturationFactor)
        {
            Bitmap adjustedBitmap = new Bitmap(filterImage.Width, filterImage.Height);
            float saturation = saturationFactor / 100f + 1f;

            for (int x = 0; x < filterImage.Width; x++)
            {
                for (int y = 0; y < filterImage.Height; y++)
                {
                    Color originalColor = filterImage.GetPixel(x, y);
                    float gray = (originalColor.R * 0.25f + originalColor.G * 0.57f + originalColor.B * 0.15f) / 255f;

                    int r = Clamp((int)(gray * (1 - saturation) + originalColor.R * saturation));
                    int g = Clamp((int)(gray * (1 - saturation) + originalColor.G * saturation));
                    int b = Clamp((int)(gray * (1 - saturation) + originalColor.B * saturation));

                    adjustedBitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return adjustedBitmap;
        }
        // Adjust Brightness
        internal Bitmap AdjustBrightness(Bitmap filterImage, int brightness)
        {
            Bitmap adjustedBitmap = new Bitmap(filterImage.Width, filterImage.Height);
            for (int x = 0; x < filterImage.Width; x++)
            {
                for (int y = 0; y < filterImage.Height; y++)
                {
                    Color originalColor = filterImage.GetPixel(x, y);
                    int r = Clamp(originalColor.R + brightness);
                    int g = Clamp(originalColor.G + brightness);
                    int b = Clamp(originalColor.B + brightness);
                    adjustedBitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return adjustedBitmap;
        }
        //Adjust Contrast
        internal Bitmap AdjustContrast(Bitmap filterImage, float contrastFactor)
        {
            Bitmap adjustedBitmap = new Bitmap(filterImage.Width, filterImage.Height);
            contrastFactor = contrastFactor / 100f + 1f;

            for (int x = 0; x < filterImage.Width; x++)
            {
                for (int y = 0; y < filterImage.Height; y++)
                {
                    Color originalColor = filterImage.GetPixel(x, y);
                    int r = Clamp((int)((originalColor.R - 128) * contrastFactor + 128));
                    int g = Clamp((int)((originalColor.G - 128) * contrastFactor + 128));
                    int b = Clamp((int)((originalColor.B - 128) * contrastFactor + 128));
                    adjustedBitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return adjustedBitmap;
        }
        // Apply Blur
        public static void ApplyGaussianBlur(Bitmap bitmap, int blurStrength)
        {
            if (blurStrength <= 0) return; // Skip if blurStrength is 0 or negative

            // Normalize: map 1–100 to 1–10 passes (adjust if you want)
            int passes = Math.Max(1, blurStrength / 10);

            int[,] kernel = new int[,]
            {
            { 1, 2, 1 },
            { 2, 4, 2 },
            { 1, 2, 1 }
            };
            int kernelWeight = 16;

            for (int i = 0; i < passes; i++)
            {
                Bitmap original = (Bitmap)bitmap.Clone();

                for (int x = 1; x < bitmap.Width - 1; x++)
                {
                    for (int y = 1; y < bitmap.Height - 1; y++)
                    {
                        int r = 0, g = 0, b = 0;

                        for (int kx = -1; kx <= 1; kx++)
                        {
                            for (int ky = -1; ky <= 1; ky++)
                            {
                                Color pixel = original.GetPixel(x + kx, y + ky);
                                int weight = kernel[kx + 1, ky + 1];

                                r += pixel.R * weight;
                                g += pixel.G * weight;
                                b += pixel.B * weight;
                            }
                        }

                        r /= kernelWeight;
                        g /= kernelWeight;
                        b /= kernelWeight;

                        bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }

                original.Dispose();
            }
        }
    }
}