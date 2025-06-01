using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;

namespace Image_Enhancer
{
    public partial class Form3 : Form
    {
        private Image<Bgr, byte> imageInput; // Non-nullable field
        private readonly Image image;

        public Form3()
        {
            InitializeComponent();
            imageInput = new Image<Bgr, byte>(1, 1); // Initialize with a blank image
        }

        private void importpic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageInput = new Image<Bgr, byte>(dialog.FileName);
                    pictureBox1.Image = imageInput.ToBitmap();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Shape Detection
        private void detectShape_Click(object sender, EventArgs e)
        {
            if (imageInput == null)
            {
                MessageBox.Show("Import an image");
                return;
            }
            try
            {
                var temp = imageInput.SmoothGaussian(5)
                                     .Convert<Gray, byte>()
                                     .ThresholdBinaryInv(new Gray(230), new Gray(255));
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat m = new Mat();

                CvInvoke.FindContours(temp, contours, m, RetrType.External,
                                      ChainApproxMethod.ChainApproxSimple);

                // Initialize variables to count shapes and colors
                int triangleCount = 0;
                int squareCount = 0;
                int rectangleCount = 0;
                int pentagonCount = 0;
                int ovalCount = 0;
                int circleCount = 0;
                int starCount = 0;

                //Color
                /*int redCount = 0;
                int greenCount = 0;
                int blueCount = 0;
                int yellowCount = 0;*/

                for (int i = 0; i < contours.Size; i++)
                {
                    double perimeter = CvInvoke.ArcLength(contours[i], true);
                    VectorOfPoint approx = new VectorOfPoint();
                    CvInvoke.ApproxPolyDP(contours[i], approx, 0.04 * perimeter, true);

                    CvInvoke.DrawContours(imageInput, contours, i, new MCvScalar(101, 155, 123), 10);

                    // Calculate moments for centroid
                    var moments = CvInvoke.Moments(contours[i]);
                    int x = (int)(moments.M10 / moments.M00);
                    int y = (int)(moments.M01 / moments.M00);

                    // Detect color
                    /*var color = DetectColor(imageInput, x, y);*/

                    // Shape detection
                    if (approx.Size == 3)
                    {
                        CvInvoke.PutText(imageInput, "Triangle", new Point(x, y),
                                         FontFace.HersheySimplex, 0.5,
                                         new MCvScalar(0, 0, 0), 2);
                        triangleCount++;
                    }

                    else if (approx.Size == 4)
                    {
                        Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                        double ar = (double)rect.Width / rect.Height;
                        double tolerance = 0.1; // Adjust this tolerance as needed
                        double minAreaThreshold = 100.0; // Adjust this threshold as needed

                        // Ensure the contour has significant area
                        if (CvInvoke.ContourArea(contours[i]) > minAreaThreshold)
                        {
                            if (Math.Abs(ar - 1.0) < tolerance) // Square or nearly square
                            {
                                CvInvoke.PutText(imageInput, "Square", new Point(x, y),
                                    FontFace.HersheySimplex, 0.5, new MCvScalar(60, 60, 60), 2);
                                squareCount++;
                            }
                            else
                            {
                                CvInvoke.PutText(imageInput, "rectangle", new Point(x, y),
                                    FontFace.HersheySimplex, 0.5, new MCvScalar(60, 60, 60), 2);
                                rectangleCount++;
                            }
                        }
                    }

                    else if (approx.Size == 10)
                    {
                        CvInvoke.PutText(imageInput, "Star", new Point(x, y),
                                         FontFace.HersheySimplex, 0.5,
                                         new MCvScalar(0, 0, 0), 2);
                        starCount++;
                    }

                    else if (approx.Size == 5)
                    {
                        CvInvoke.PutText(imageInput, "Pentagon", new Point(x, y),
                                         FontFace.HersheySimplex, 0.5,
                                         new MCvScalar(0, 0, 0), 2);
                        pentagonCount++;
                    }
                    else if (approx.Size == 5)
                    {
                        CvInvoke.PutText(imageInput, "oval", new Point(x, y),
                                         FontFace.HersheySimplex, 0.5,
                                         new MCvScalar(0, 0, 0), 2);
                        ovalCount++;
                    }
                    else
                    {
                        CvInvoke.PutText(imageInput, "Circle", new Point(x, y),
                                         FontFace.HersheySimplex, 0.5,
                                         new MCvScalar(0, 0, 0), 2);
                        circleCount++;
                    }

                    // Count colors
                    /*switch (color)
                    {
                        case "Red":
                            redCount++;
                            break;
                        case "Green":
                            greenCount++;
                            break;
                        case "Blue":
                            blueCount++;
                            break;
                        case "Yellow":
                            yellowCount++;
                            break;
                    }*/
                }

                // Update the textboxes with the counts
                triangle.Text = triangleCount.ToString();
                square.Text = squareCount.ToString();
                rectangle.Text = rectangleCount.ToString();
                pentagon.Text = pentagonCount.ToString();
                oval.Text = ovalCount.ToString();
                circle.Text = circleCount.ToString();

                /*redBox.Text = redCount.ToString();
                greenBox.Text = greenCount.ToString();
                blueBox.Text = blueCount.ToString();
                yellowBox.Text = yellowCount.ToString();*/
                star.Text = starCount.ToString();

                pictureBox2.Image = imageInput.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DetectColor_Click_1(object sender, EventArgs e)
        {
            if (imageInput == null)
            {
                MessageBox.Show("Import an image first");
                return;
            }

            try
            {
                // Convert image to HSV color space
                Image<Hsv, byte> hsvImage = imageInput.Convert<Hsv, byte>();

                // Get color masks for Red, Green, Blue, Yellow
                Mat redMask = GetColorMask(hsvImage, new Hsv(0, 120, 70), new Hsv(10, 255, 255)) +
                              GetColorMask(hsvImage, new Hsv(170, 120, 70), new Hsv(180, 255, 255)); // Red has two ranges
                Mat greenMask = GetColorMask(hsvImage, new Hsv(35, 100, 100), new Hsv(85, 255, 255));
                Mat blueMask = GetColorMask(hsvImage, new Hsv(100, 150, 100), new Hsv(140, 255, 255));
                Mat yellowMask = GetColorMask(hsvImage, new Hsv(20, 100, 100), new Hsv(30, 255, 255));

                // Count distinct shapes per color
                int redShapes = CountShapes(redMask);
                int greenShapes = CountShapes(greenMask);
                int blueShapes = CountShapes(blueMask);
                int yellowShapes = CountShapes(yellowMask);

                // Display results in textboxes
                red.Text = redShapes.ToString();
                green.Text = greenShapes.ToString();
                blue.Text = blueShapes.ToString();
                yellow.Text = yellowShapes.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error detecting shapes: {ex.Message}");
            }
        }

        private Mat GetColorMask(Image<Hsv, byte> hsvImage, Hsv lower, Hsv upper)
        {
            Mat mask = new Mat();
            CvInvoke.InRange(hsvImage, new ScalarArray(lower.MCvScalar), new ScalarArray(upper.MCvScalar), mask);
            return mask;
        }

        private int CountShapes(Mat mask)
        {
            Mat hierarchy = new Mat();
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(mask, contours, hierarchy, RetrType.External, ChainApproxMethod.ChainApproxSimple);

            return contours.Size; // Number of detected shapes
        }

        private void originalbutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void centeroid_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wapa ni sud sir hehe", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void horizontalbttn_Click(object sender, EventArgs e)
        {
            Bitmap bmp;
            if (pictureBox2.Image != null)
            {
                bmp = new Bitmap(pictureBox2.Image);
            }
            else
            {
                bmp = new Bitmap(pictureBox1.Image);
            }

            Bitmap mirrorImg = new Bitmap(bmp.Width, bmp.Height);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    mirrorImg.SetPixel(x, y, bmp.GetPixel(bmp.Width - x - 1, y));
                }
            }
            pictureBox2.Image = mirrorImg;
        }
    }
    }


