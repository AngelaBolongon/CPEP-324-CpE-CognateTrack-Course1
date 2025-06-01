namespace Image_Enhancer
{
    partial class Form02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            adaptivebnz = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            threshold1button = new Button();
            threshold1n2button = new Button();
            segmentationbutton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            T1valueText = new TextBox();
            T2valueText = new TextBox();
            t1 = new Label();
            t2 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            thresholdBar = new TrackBar();
            tableLayoutPanel5 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            importpicture = new Button();
            originalbutton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thresholdBar).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Lavender;
            splitContainer1.Panel1.Controls.Add(adaptivebnz);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel3);
            splitContainer1.Panel1.Controls.Add(segmentationbutton);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LavenderBlush;
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel5);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel4);
            splitContainer1.Panel2.Controls.Add(importpicture);
            splitContainer1.Panel2.Controls.Add(originalbutton);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1577, 966);
            splitContainer1.SplitterDistance = 558;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // adaptivebnz
            // 
            adaptivebnz.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adaptivebnz.Location = new Point(12, 670);
            adaptivebnz.Name = "adaptivebnz";
            adaptivebnz.Size = new Size(534, 126);
            adaptivebnz.TabIndex = 7;
            adaptivebnz.Text = "Adaptive Binarization";
            adaptivebnz.UseVisualStyleBackColor = true;
            adaptivebnz.Click += adaptivebnz_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(threshold1button, 0, 0);
            tableLayoutPanel3.Controls.Add(threshold1n2button, 1, 0);
            tableLayoutPanel3.Location = new Point(12, 333);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(534, 114);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // threshold1button
            // 
            threshold1button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            threshold1button.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            threshold1button.Location = new Point(4, 4);
            threshold1button.Name = "threshold1button";
            threshold1button.Size = new Size(259, 103);
            threshold1button.TabIndex = 2;
            threshold1button.Text = "Threshold 1\r\n";
            threshold1button.UseVisualStyleBackColor = true;
            threshold1button.Click += threshold1button_Click;
            // 
            // threshold1n2button
            // 
            threshold1n2button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            threshold1n2button.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            threshold1n2button.Location = new Point(270, 4);
            threshold1n2button.Name = "threshold1n2button";
            threshold1n2button.Size = new Size(260, 103);
            threshold1n2button.TabIndex = 3;
            threshold1n2button.Text = "Threshold\r\n 1 and 2";
            threshold1n2button.UseVisualStyleBackColor = true;
            threshold1n2button.Click += threshold1n2button_Click;
            // 
            // segmentationbutton
            // 
            segmentationbutton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            segmentationbutton.FlatStyle = FlatStyle.System;
            segmentationbutton.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            segmentationbutton.Location = new Point(12, 62);
            segmentationbutton.Name = "segmentationbutton";
            segmentationbutton.Size = new Size(534, 132);
            segmentationbutton.TabIndex = 5;
            segmentationbutton.Text = "SEGMENTATION";
            segmentationbutton.UseVisualStyleBackColor = true;
            segmentationbutton.Click += segmentationbutton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.88636F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.113636F));
            tableLayoutPanel2.Controls.Add(T1valueText, 0, 0);
            tableLayoutPanel2.Controls.Add(T2valueText, 0, 1);
            tableLayoutPanel2.Controls.Add(t1, 1, 0);
            tableLayoutPanel2.Controls.Add(t2, 1, 1);
            tableLayoutPanel2.Location = new Point(12, 453);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(534, 204);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // T1valueText
            // 
            T1valueText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            T1valueText.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            T1valueText.Location = new Point(4, 4);
            T1valueText.Multiline = true;
            T1valueText.Name = "T1valueText";
            T1valueText.Size = new Size(365, 93);
            T1valueText.TabIndex = 5;
            T1valueText.TextAlign = HorizontalAlignment.Center;
            // 
            // T2valueText
            // 
            T2valueText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            T2valueText.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            T2valueText.Location = new Point(4, 105);
            T2valueText.Multiline = true;
            T2valueText.Name = "T2valueText";
            T2valueText.Size = new Size(365, 93);
            T2valueText.TabIndex = 6;
            T2valueText.TextAlign = HorizontalAlignment.Center;
            // 
            // t1
            // 
            t1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            t1.AutoSize = true;
            t1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t1.Location = new Point(376, 1);
            t1.Name = "t1";
            t1.Size = new Size(154, 100);
            t1.TabIndex = 5;
            t1.Text = "\r\nTHRESHOLD 1\r\n";
            // 
            // t2
            // 
            t2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            t2.AutoSize = true;
            t2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t2.Location = new Point(376, 102);
            t2.Name = "t2";
            t2.Size = new Size(154, 101);
            t2.TabIndex = 7;
            t2.Text = "\r\nTHRESHOLD 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 211);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 1;
            label2.Text = "THRESHOLDING :";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(thresholdBar, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 252);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(534, 75);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // thresholdBar
            // 
            thresholdBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            thresholdBar.Location = new Point(5, 5);
            thresholdBar.Maximum = 50;
            thresholdBar.Minimum = -50;
            thresholdBar.Name = "thresholdBar";
            thresholdBar.Size = new Size(524, 56);
            thresholdBar.TabIndex = 0;
            thresholdBar.Scroll += thresholdBar_Scroll;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel5.Location = new Point(246, 555);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(547, 401);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(541, 395);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel4.Location = new Point(19, 68);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(979, 482);
            tableLayoutPanel4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(483, 476);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(492, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(484, 476);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // importpicture
            // 
            importpicture.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            importpicture.Location = new Point(743, 26);
            importpicture.Name = "importpicture";
            importpicture.Size = new Size(138, 33);
            importpicture.TabIndex = 8;
            importpicture.Text = "Import Picture";
            importpicture.UseVisualStyleBackColor = true;
            importpicture.Click += importpicture_Click;
            // 
            // originalbutton
            // 
            originalbutton.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            originalbutton.Location = new Point(887, 26);
            originalbutton.Name = "originalbutton";
            originalbutton.Size = new Size(116, 33);
            originalbutton.TabIndex = 7;
            originalbutton.Text = "Reset ";
            originalbutton.UseVisualStyleBackColor = true;
            originalbutton.Click += originalbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(13, 36);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 6;
            label1.Text = "OUTPUT HERE:";
            // 
            // Form02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1577, 966);
            Controls.Add(splitContainer1);
            Name = "Form02";
            Text = "Threshold";
            Load += Form2_0_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)thresholdBar).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Button originalbutton;
        private Button importpicture;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TrackBar thresholdBar;
        private TableLayoutPanel tableLayoutPanel2;
        private Button threshold1n2button;
        private Button threshold1button;
        private TextBox T1valueText;
        private TextBox T2valueText;
        private Label t1;
        private Label t2;
        private Button segmentationbutton;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button adaptivebnz;
    }
}