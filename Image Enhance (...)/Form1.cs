using Emgu.CV;
using Emgu.CV.Structure;
using Image_Enhancer;
using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Windows.Controls.Ribbon;
using System.Windows.Forms;

namespace Image_Enhancer
{
    public partial class Form1 : Form

    {
        private ColorFilters colorFilters = new ColorFilters();  // Declare the instance

        public string OriginalImage { get; private set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Form1()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // loads the original image
        }

        private void greyscalebutton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                // Create a new bitmap from the PictureBox image
                Bitmap filterImage = new Bitmap(pictureBox1.Image);

                // Call the Greyscale method from ColorFilters
                filterImage = colorFilters.Greyscale(filterImage);

                // Display in PictureBox2
                pictureBox2.Image = filterImage;
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // loads the converted image
        }

        private void blacknwhitebutton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap filterImage = new Bitmap(pictureBox1.Image);
                ColorFilters colorFilters = new ColorFilters();
                filterImage = colorFilters.BlackAndWhite(filterImage, 128); // Adjust threshold if needed
                pictureBox2.Image = filterImage;
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.PinkFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void originalbutton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                // Create a new bitmap to store the greyscaled image
                Bitmap actualImage = new Bitmap(pictureBox1.Image);

                // Display the modified image in pictureBox2
                pictureBox2.Image = actualImage;
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void antique_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.Antique(new Bitmap(pictureBox1.Image));
            }
        }

        private void cinematic_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.CinematicFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void inverted_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.Invert(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void cyan_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.CyanTint(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void green_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.GreenTint(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void red_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.RedTint(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void blue_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.BlueTint(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void yellowish_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.YellowTint(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void purple_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.PurpleTint(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Rgbbox.RGB(pictureBox1, pictureBox2, trackBarRed, trackBarGreen, trackBarBlue);
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Rgbbox.RGB(pictureBox1, pictureBox2, trackBarRed, trackBarGreen, trackBarBlue);
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Rgbbox.RGB(pictureBox1, pictureBox2, trackBarRed, trackBarGreen, trackBarBlue);
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }
        private void trackBarOpacity_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.AdjustOpacity(new Bitmap(pictureBox1.Image), trackBarOpacity.Value);
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.AdjustBrightness(new Bitmap(pictureBox1.Image), trackBarBrightness.Value);
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void trackBarSaturation_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.AdjustSaturation(new Bitmap(pictureBox1.Image), trackBarSaturation.Value);
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ColorFilters colorFilters = new ColorFilters();
                pictureBox2.Image = colorFilters.AdjustContrast(new Bitmap(pictureBox1.Image), trackBarContrast.Value);
            }
            else
            {
                MessageBox.Show("Import Image!");
            }
        }

        private void trackBarBlur_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int blurStrength = trackBarBlur.Value; // -100 to +100

                // Start from original image each time
                Bitmap original = new Bitmap(pictureBox1.Image);
                Bitmap processed = (Bitmap)original.Clone();

                ColorFilters.ApplyGaussianBlur(processed, blurStrength);

                pictureBox2.Image = processed;
                original.Dispose();
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form02 newForm = new Form02(); // Create an instance of THRESHOLDING
            newForm.Show(); // Show THRESHOLDING
        }

        private void dETECTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(); // Create an instance of DETECTION
            newForm.Show(); // Show DETECTION
        }

        private void cONVULTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Convultion newForm = new Convultion(); // Create an instance of DETECTION
            newForm.Show(); // Show DETECTION
        }
    }
}