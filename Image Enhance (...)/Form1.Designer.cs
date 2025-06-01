namespace Image_Enhancer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            trackBarBlur = new TrackBar();
            trackBarSaturation = new TrackBar();
            trackBarContrast = new TrackBar();
            trackBarBrightness = new TrackBar();
            trackBarOpacity = new TrackBar();
            panel1 = new Panel();
            imageBoxblue = new Emgu.CV.UI.ImageBox();
            imageBoxgreen = new Emgu.CV.UI.ImageBox();
            imageBoxred = new Emgu.CV.UI.ImageBox();
            trackBarBlue = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarRed = new TrackBar();
            toolbar = new Button();
            colorfilters = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            greyscalebutton = new Button();
            blacknwhitebutton = new Button();
            antique = new Button();
            cinematic = new Button();
            inverted = new Button();
            Pink = new Button();
            cyan = new Button();
            green = new Button();
            red = new Button();
            blue = new Button();
            yellowish = new Button();
            purple = new Button();
            label1 = new Label();
            originalbutton = new Button();
            pictureBox2 = new PictureBox();
            importpicture = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            dETECTIONToolStripMenuItem = new ToolStripMenuItem();
            cONVULTIONToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBlur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSaturation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarContrast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarOpacity).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBoxblue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxgreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxred).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Lavender;
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(colorfilters);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LavenderBlush;
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(originalbutton);
            splitContainer1.Panel2.Controls.Add(pictureBox2);
            splitContainer1.Panel2.Controls.Add(importpicture);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(menuStrip1);
            splitContainer1.Size = new Size(1924, 889);
            splitContainer1.SplitterDistance = 585;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(trackBarBlur);
            panel2.Controls.Add(trackBarSaturation);
            panel2.Controls.Add(trackBarContrast);
            panel2.Controls.Add(trackBarBrightness);
            panel2.Controls.Add(trackBarOpacity);
            panel2.Location = new Point(12, 550);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 336);
            panel2.TabIndex = 3;
            // 
            // button5
            // 
            button5.Location = new Point(4, 277);
            button5.Name = "button5";
            button5.Size = new Size(85, 29);
            button5.TabIndex = 10;
            button5.Text = "blur";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(4, 215);
            button4.Name = "button4";
            button4.Size = new Size(85, 29);
            button4.TabIndex = 9;
            button4.Text = "saturation";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(4, 153);
            button3.Name = "button3";
            button3.Size = new Size(85, 29);
            button3.TabIndex = 8;
            button3.Text = "contrast";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(4, 91);
            button2.Name = "button2";
            button2.Size = new Size(85, 29);
            button2.TabIndex = 7;
            button2.Text = "brightness";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(4, 29);
            button1.Name = "button1";
            button1.Size = new Size(85, 29);
            button1.TabIndex = 6;
            button1.Text = "opacity";
            button1.UseVisualStyleBackColor = true;
            // 
            // trackBarBlur
            // 
            trackBarBlur.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBarBlur.Location = new Point(95, 277);
            trackBarBlur.Maximum = 100;
            trackBarBlur.Minimum = -100;
            trackBarBlur.Name = "trackBarBlur";
            trackBarBlur.Size = new Size(460, 56);
            trackBarBlur.TabIndex = 5;
            trackBarBlur.Scroll += trackBarBlur_Scroll;
            // 
            // trackBarSaturation
            // 
            trackBarSaturation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBarSaturation.Location = new Point(95, 215);
            trackBarSaturation.Maximum = 100;
            trackBarSaturation.Minimum = -100;
            trackBarSaturation.Name = "trackBarSaturation";
            trackBarSaturation.Size = new Size(460, 56);
            trackBarSaturation.TabIndex = 4;
            trackBarSaturation.Scroll += trackBarSaturation_Scroll;
            // 
            // trackBarContrast
            // 
            trackBarContrast.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBarContrast.Location = new Point(95, 153);
            trackBarContrast.Maximum = 100;
            trackBarContrast.Minimum = -100;
            trackBarContrast.Name = "trackBarContrast";
            trackBarContrast.Size = new Size(460, 56);
            trackBarContrast.TabIndex = 3;
            trackBarContrast.Scroll += trackBarContrast_Scroll;
            // 
            // trackBarBrightness
            // 
            trackBarBrightness.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBarBrightness.Location = new Point(95, 91);
            trackBarBrightness.Maximum = 100;
            trackBarBrightness.Minimum = -100;
            trackBarBrightness.Name = "trackBarBrightness";
            trackBarBrightness.Size = new Size(460, 56);
            trackBarBrightness.TabIndex = 2;
            trackBarBrightness.Scroll += trackBarBrightness_Scroll;
            // 
            // trackBarOpacity
            // 
            trackBarOpacity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBarOpacity.Location = new Point(95, 29);
            trackBarOpacity.Maximum = 100;
            trackBarOpacity.Minimum = -100;
            trackBarOpacity.Name = "trackBarOpacity";
            trackBarOpacity.Size = new Size(460, 56);
            trackBarOpacity.TabIndex = 1;
            trackBarOpacity.Scroll += trackBarOpacity_Scroll;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(imageBoxblue);
            panel1.Controls.Add(imageBoxgreen);
            panel1.Controls.Add(imageBoxred);
            panel1.Controls.Add(trackBarBlue);
            panel1.Controls.Add(trackBarGreen);
            panel1.Controls.Add(trackBarRed);
            panel1.Controls.Add(toolbar);
            panel1.Location = new Point(12, 332);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 218);
            panel1.TabIndex = 2;
            // 
            // imageBoxblue
            // 
            imageBoxblue.BackColor = Color.Blue;
            imageBoxblue.Location = new Point(4, 162);
            imageBoxblue.Name = "imageBoxblue";
            imageBoxblue.Size = new Size(29, 56);
            imageBoxblue.TabIndex = 5;
            imageBoxblue.TabStop = false;
            // 
            // imageBoxgreen
            // 
            imageBoxgreen.BackColor = Color.Green;
            imageBoxgreen.Location = new Point(4, 100);
            imageBoxgreen.Name = "imageBoxgreen";
            imageBoxgreen.Size = new Size(29, 56);
            imageBoxgreen.TabIndex = 4;
            imageBoxgreen.TabStop = false;
            // 
            // imageBoxred
            // 
            imageBoxred.BackColor = Color.Red;
            imageBoxred.Location = new Point(4, 38);
            imageBoxred.Name = "imageBoxred";
            imageBoxred.Size = new Size(29, 56);
            imageBoxred.TabIndex = 2;
            imageBoxred.TabStop = false;
            // 
            // trackBarBlue
            // 
            trackBarBlue.BackColor = Color.Lavender;
            trackBarBlue.Location = new Point(39, 162);
            trackBarBlue.Maximum = 100;
            trackBarBlue.Minimum = -100;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(516, 56);
            trackBarBlue.TabIndex = 3;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.BackColor = Color.Lavender;
            trackBarGreen.Location = new Point(39, 100);
            trackBarGreen.Maximum = 100;
            trackBarGreen.Minimum = -100;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(516, 56);
            trackBarGreen.TabIndex = 2;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            // 
            // trackBarRed
            // 
            trackBarRed.BackColor = Color.Lavender;
            trackBarRed.Location = new Point(39, 38);
            trackBarRed.Maximum = 100;
            trackBarRed.Minimum = -100;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(516, 56);
            trackBarRed.TabIndex = 1;
            trackBarRed.Scroll += trackBarRed_Scroll;
            // 
            // toolbar
            // 
            toolbar.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolbar.ForeColor = SystemColors.ControlDarkDark;
            toolbar.Location = new Point(4, 6);
            toolbar.Name = "toolbar";
            toolbar.Size = new Size(551, 26);
            toolbar.TabIndex = 0;
            toolbar.Text = "Apply Tool Bar";
            toolbar.UseVisualStyleBackColor = true;
            // 
            // colorfilters
            // 
            colorfilters.AutoSize = true;
            colorfilters.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colorfilters.ForeColor = Color.CornflowerBlue;
            colorfilters.Location = new Point(12, 20);
            colorfilters.Name = "colorfilters";
            colorfilters.Size = new Size(208, 34);
            colorfilters.TabIndex = 1;
            colorfilters.Text = "Color Filters";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.AliceBlue;
            flowLayoutPanel2.Controls.Add(greyscalebutton);
            flowLayoutPanel2.Controls.Add(blacknwhitebutton);
            flowLayoutPanel2.Controls.Add(antique);
            flowLayoutPanel2.Controls.Add(cinematic);
            flowLayoutPanel2.Controls.Add(inverted);
            flowLayoutPanel2.Controls.Add(Pink);
            flowLayoutPanel2.Controls.Add(cyan);
            flowLayoutPanel2.Controls.Add(green);
            flowLayoutPanel2.Controls.Add(red);
            flowLayoutPanel2.Controls.Add(blue);
            flowLayoutPanel2.Controls.Add(yellowish);
            flowLayoutPanel2.Controls.Add(purple);
            flowLayoutPanel2.Location = new Point(12, 57);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(558, 275);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // greyscalebutton
            // 
            greyscalebutton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greyscalebutton.Location = new Point(3, 3);
            greyscalebutton.Name = "greyscalebutton";
            greyscalebutton.Size = new Size(274, 38);
            greyscalebutton.TabIndex = 0;
            greyscalebutton.Text = "Greyscale";
            greyscalebutton.UseVisualStyleBackColor = true;
            greyscalebutton.Click += greyscalebutton_Click;
            // 
            // blacknwhitebutton
            // 
            blacknwhitebutton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            blacknwhitebutton.Location = new Point(283, 3);
            blacknwhitebutton.Name = "blacknwhitebutton";
            blacknwhitebutton.Size = new Size(272, 38);
            blacknwhitebutton.TabIndex = 1;
            blacknwhitebutton.Text = "Black n White";
            blacknwhitebutton.UseVisualStyleBackColor = true;
            blacknwhitebutton.Click += blacknwhitebutton_Click;
            // 
            // antique
            // 
            antique.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            antique.Location = new Point(3, 47);
            antique.Name = "antique";
            antique.Size = new Size(274, 35);
            antique.TabIndex = 3;
            antique.Text = "Antique";
            antique.UseVisualStyleBackColor = true;
            antique.Click += antique_Click;
            // 
            // cinematic
            // 
            cinematic.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cinematic.Location = new Point(283, 47);
            cinematic.Name = "cinematic";
            cinematic.Size = new Size(272, 35);
            cinematic.TabIndex = 4;
            cinematic.Text = "Cinematic";
            cinematic.UseVisualStyleBackColor = true;
            cinematic.Click += cinematic_Click;
            // 
            // inverted
            // 
            inverted.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inverted.Location = new Point(3, 88);
            inverted.Name = "inverted";
            inverted.Size = new Size(274, 40);
            inverted.TabIndex = 6;
            inverted.Text = "Shade Shift";
            inverted.UseVisualStyleBackColor = true;
            inverted.Click += inverted_Click;
            // 
            // Pink
            // 
            Pink.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pink.Location = new Point(283, 88);
            Pink.Name = "Pink";
            Pink.Size = new Size(272, 40);
            Pink.TabIndex = 2;
            Pink.Text = "Strawberry Pink";
            Pink.UseVisualStyleBackColor = true;
            Pink.Click += Pink_Click;
            // 
            // cyan
            // 
            cyan.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyan.Location = new Point(3, 134);
            cyan.Name = "cyan";
            cyan.Size = new Size(274, 38);
            cyan.TabIndex = 8;
            cyan.Text = "Oceanic";
            cyan.UseVisualStyleBackColor = true;
            cyan.Click += cyan_Click;
            // 
            // green
            // 
            green.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            green.Location = new Point(283, 134);
            green.Name = "green";
            green.Size = new Size(272, 38);
            green.TabIndex = 9;
            green.Text = "River Dale";
            green.UseVisualStyleBackColor = true;
            green.Click += green_Click;
            // 
            // red
            // 
            red.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            red.Location = new Point(3, 178);
            red.Name = "red";
            red.Size = new Size(274, 41);
            red.TabIndex = 10;
            red.Text = "Apple Pie";
            red.UseVisualStyleBackColor = true;
            red.Click += red_Click;
            // 
            // blue
            // 
            blue.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            blue.Location = new Point(283, 178);
            blue.Name = "blue";
            blue.Size = new Size(272, 41);
            blue.TabIndex = 11;
            blue.Text = "Sky Blue";
            blue.UseVisualStyleBackColor = true;
            blue.Click += blue_Click;
            // 
            // yellowish
            // 
            yellowish.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yellowish.Location = new Point(3, 225);
            yellowish.Name = "yellowish";
            yellowish.Size = new Size(274, 40);
            yellowish.TabIndex = 12;
            yellowish.Text = "Autumn";
            yellowish.UseVisualStyleBackColor = true;
            yellowish.Click += yellowish_Click;
            // 
            // purple
            // 
            purple.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purple.Location = new Point(283, 225);
            purple.Name = "purple";
            purple.Size = new Size(272, 40);
            purple.TabIndex = 13;
            purple.Text = "Ube";
            purple.UseVisualStyleBackColor = true;
            purple.Click += purple_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(18, 63);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 5;
            label1.Text = "OUTPUT HERE:";
            // 
            // originalbutton
            // 
            originalbutton.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            originalbutton.Location = new Point(1198, 51);
            originalbutton.Name = "originalbutton";
            originalbutton.Size = new Size(116, 33);
            originalbutton.TabIndex = 4;
            originalbutton.Text = "Reset Filter";
            originalbutton.UseVisualStyleBackColor = true;
            originalbutton.Click += originalbutton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(681, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(642, 779);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // importpicture
            // 
            importpicture.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            importpicture.Location = new Point(1045, 51);
            importpicture.Name = "importpicture";
            importpicture.Size = new Size(138, 33);
            importpicture.TabIndex = 3;
            importpicture.Text = "Import Picture";
            importpicture.UseVisualStyleBackColor = true;
            importpicture.Click += importpicture_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(18, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(642, 779);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, dETECTIONToolStripMenuItem, cONVULTIONToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1335, 29);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(163, 25);
            toolStripMenuItem1.Text = "THRESHOLDING";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // dETECTIONToolStripMenuItem
            // 
            dETECTIONToolStripMenuItem.Font = new Font("Tahoma", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dETECTIONToolStripMenuItem.Name = "dETECTIONToolStripMenuItem";
            dETECTIONToolStripMenuItem.Size = new Size(122, 25);
            dETECTIONToolStripMenuItem.Text = "DETECTION";
            dETECTIONToolStripMenuItem.Click += dETECTIONToolStripMenuItem_Click;
            // 
            // cONVULTIONToolStripMenuItem
            // 
            cONVULTIONToolStripMenuItem.Font = new Font("Tahoma", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cONVULTIONToolStripMenuItem.Name = "cONVULTIONToolStripMenuItem";
            cONVULTIONToolStripMenuItem.Size = new Size(152, 25);
            cONVULTIONToolStripMenuItem.Text = "CONVOLUTION";
            cONVULTIONToolStripMenuItem.Click += cONVULTIONToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1924, 889);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ColorMend";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBlur).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSaturation).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarContrast).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarOpacity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageBoxblue).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxgreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxred).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label colorfilters;
        private Button greyscalebutton;
        private Button blacknwhitebutton;
        private Button Pink;
        private Button antique;
        private Button cinematic;
        private Button inverted;
        private Button cyan;
        private Button green;
        private Button importpicture;
        private Button originalbutton;
        private Button red;
        private Button blue;
        private Label label1;
        private Button yellowish;
        private Button purple;
        private Panel panel1;
        private TrackBar trackBarBlue;
        private TrackBar trackBarGreen;
        private TrackBar trackBarRed;
        private Button toolbar;
        private Emgu.CV.UI.ImageBox imageBoxblue;
        private Emgu.CV.UI.ImageBox imageBoxgreen;
        private Emgu.CV.UI.ImageBox imageBoxred;
        private Panel panel2;
        private TrackBar trackBarSaturation;
        private TrackBar trackBarContrast;
        private TrackBar trackBarBrightness;
        private TrackBar trackBarOpacity;
        private TrackBar trackBarBlur;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem dETECTIONToolStripMenuItem;
        private ToolStripMenuItem cONVULTIONToolStripMenuItem;
    }
}
