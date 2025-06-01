using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OpenCvSharp.LineIterator;
using System.Windows.Media.Media3D;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;

namespace Image_Enhancer
{
    public partial class Form02 : Form
    {
        // Declare variables at the class level
        private Bitmap bmp = null!;
        private Bitmap orig = null!;
        private int width;
        private int height;
        private Color pixel;
        private int AreaofObject;

        public Form02()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) // wala ra ni
        {

        }

        private void importpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Image files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(OpenFileDialog.FileName);
            }
        }

        private void originalbutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e) // wala rani
        {

        }

        private void Form2_0_Load(object sender, EventArgs e)//kani fud
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)// wla sad ni
        {

        }

        private void thresholdBar_Scroll(object sender, EventArgs e)
        {
            int threshing = thresholdBar.Value;
            T1valueText.Text = threshing.ToString();

            int difference = thresholdBar.Maximum - threshing;
            int T2 = threshing + difference > thresholdBar.Maximum ? thresholdBar.Maximum : threshing + difference;
            T2valueText.Text = T2.ToString(); // Set T2 based on T1 and track bar value
            ApplyThreshold();
        }
        private void ApplyThreshold()
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    bmp = new Bitmap(pictureBox1.Image);
                    orig = new Bitmap(pictureBox1.Image);
                    width = bmp.Width;
                    height = bmp.Height;
                    int min = int.Parse(T1valueText.Text);
                    int max = int.Parse(T2valueText.Text);
                    int objArea = 0;

                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            pixel = bmp.GetPixel(x, y);
                            double avg = (pixel.R + pixel.G + pixel.B) / 3.0;
                            if (avg >= min && avg <= max)
                            {
                                bmp.SetPixel(x, y, Color.Black);
                                objArea++;
                            }
                            else
                            {
                                bmp.SetPixel(x, y, Color.White);
                                orig.SetPixel(x, y, Color.White);
                            }
                        }
                    }

                    AreaofObject = objArea;
                    pictureBox2.Image = bmp; // Update pictureBox2 with thresholded image
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void threshing()
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    bmp = new Bitmap(pictureBox1.Image);
                    orig = new Bitmap(pictureBox1.Image);
                    width = bmp.Width;
                    height = bmp.Height;
                    int min = int.Parse(T1valueText.Text);
                    int max = int.Parse(T2valueText.Text);
                    int objArea = 0;

                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            pixel = bmp.GetPixel(x, y);
                            double avg = (pixel.R + pixel.G + pixel.B) / 3.0;
                            if (avg >= min && avg <= max)
                            {
                                bmp.SetPixel(x, y, Color.Black);
                                objArea++;
                            }
                            else
                            {
                                bmp.SetPixel(x, y, Color.White);
                                orig.SetPixel(x, y, Color.White);
                            }
                        }
                    }
                    AreaofObject = objArea;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void threshold1button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(T1valueText.Text) || string.IsNullOrWhiteSpace(T2valueText.Text))
            {
                MessageBox.Show("Enter values T1 and T2");
                return;
            }
            try
            {
                if (pictureBox1.Image != null)
                {
                    bmp = new Bitmap(pictureBox1.Image);
                    width = bmp.Width;
                    height = bmp.Height;
                    int threshold = int.Parse(T1valueText.Text);
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        for (int y = 0; y < bmp.Height; y++)
                        {
                            Color pixel = bmp.GetPixel(x, y);
                            int avg = (int)((pixel.R + pixel.G + pixel.B) / 3);
                            if (avg > threshold)
                            {
                                bmp.SetPixel(x, y, Color.White);
                            }
                            else
                            {
                                bmp.SetPixel(x, y, Color.Black);
                            }
                        }
                    }
                    pictureBox2.Image = bmp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void threshold1n2button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(T1valueText.Text) || string.IsNullOrWhiteSpace(T2valueText.Text))
            {
                MessageBox.Show("Enter values T1 and T2");
                return;
            }
            ApplyThreshold();
            pictureBox2.Image = bmp;
        }

        private void segmentationbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(T1valueText.Text) || string.IsNullOrWhiteSpace(T2valueText.Text))
            {
                MessageBox.Show("Enter values T1 and T2");
                return;
            }
            threshing();
            pictureBox3.Image = bmp;
            pictureBox3.Image = orig;
        }

        private void adaptivebnz_Click(object sender, EventArgs e)
        {
       
        }
    }
    }


