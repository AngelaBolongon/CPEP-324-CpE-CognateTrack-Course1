namespace Image_Enhancer
{
    partial class Form3
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
            panel1 = new Panel();
            embossbtn = new Button();
            lssybttn = new Button();
            alldrcttbttn = new Button();
            hrntlvrtclbutton = new Button();
            vertcalbttn = new Button();
            horizontalbttn = new Button();
            areaimage = new Button();
            centeroidimage = new Button();
            DetectColor = new Button();
            detectShape = new Button();
            originalbutton = new Button();
            importpic = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            rectangle = new TextBox();
            triangle = new TextBox();
            circle = new TextBox();
            star = new TextBox();
            pentagon = new TextBox();
            oval = new TextBox();
            square = new TextBox();
            label9 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            yellow = new TextBox();
            blue = new TextBox();
            green = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            red = new TextBox();
            label5 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(areaimage);
            splitContainer1.Panel1.Controls.Add(centeroidimage);
            splitContainer1.Panel1.Controls.Add(DetectColor);
            splitContainer1.Panel1.Controls.Add(detectShape);
            splitContainer1.Panel1.Controls.Add(originalbutton);
            splitContainer1.Panel1.Controls.Add(importpic);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LavenderBlush;
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel3);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(1242, 920);
            splitContainer1.SplitterDistance = 882;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(embossbtn);
            panel1.Controls.Add(lssybttn);
            panel1.Controls.Add(alldrcttbttn);
            panel1.Controls.Add(hrntlvrtclbutton);
            panel1.Controls.Add(vertcalbttn);
            panel1.Controls.Add(horizontalbttn);
            panel1.Location = new Point(6, 566);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 342);
            panel1.TabIndex = 11;
            // 
            // embossbtn
            // 
            embossbtn.Location = new Point(2, 286);
            embossbtn.Name = "embossbtn";
            embossbtn.Size = new Size(428, 51);
            embossbtn.TabIndex = 5;
            embossbtn.Text = "EMBOSS";
            embossbtn.UseVisualStyleBackColor = true;
            // 
            // lssybttn
            // 
            lssybttn.Location = new Point(2, 228);
            lssybttn.Name = "lssybttn";
            lssybttn.Size = new Size(428, 52);
            lssybttn.TabIndex = 4;
            lssybttn.Text = "LOSSY";
            lssybttn.UseVisualStyleBackColor = true;
            // 
            // alldrcttbttn
            // 
            alldrcttbttn.Location = new Point(2, 168);
            alldrcttbttn.Name = "alldrcttbttn";
            alldrcttbttn.Size = new Size(428, 53);
            alldrcttbttn.TabIndex = 3;
            alldrcttbttn.Text = "ALL DIRECTION";
            alldrcttbttn.UseVisualStyleBackColor = true;
            // 
            // hrntlvrtclbutton
            // 
            hrntlvrtclbutton.Location = new Point(2, 110);
            hrntlvrtclbutton.Name = "hrntlvrtclbutton";
            hrntlvrtclbutton.Size = new Size(428, 52);
            hrntlvrtclbutton.TabIndex = 2;
            hrntlvrtclbutton.Text = "HORIZONTA VERTICAL";
            hrntlvrtclbutton.UseVisualStyleBackColor = true;
            // 
            // vertcalbttn
            // 
            vertcalbttn.Location = new Point(2, 55);
            vertcalbttn.Name = "vertcalbttn";
            vertcalbttn.Size = new Size(428, 49);
            vertcalbttn.TabIndex = 1;
            vertcalbttn.Text = "VERTICAL";
            vertcalbttn.UseVisualStyleBackColor = true;
            // 
            // horizontalbttn
            // 
            horizontalbttn.Location = new Point(2, 4);
            horizontalbttn.Name = "horizontalbttn";
            horizontalbttn.Size = new Size(428, 45);
            horizontalbttn.TabIndex = 0;
            horizontalbttn.Text = "HORIZONTAL";
            horizontalbttn.UseVisualStyleBackColor = true;
            horizontalbttn.Click += horizontalbttn_Click;
            // 
            // areaimage
            // 
            areaimage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            areaimage.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            areaimage.Location = new Point(447, 767);
            areaimage.Name = "areaimage";
            areaimage.Size = new Size(429, 64);
            areaimage.TabIndex = 10;
            areaimage.Text = "AREA IMAGE";
            areaimage.UseVisualStyleBackColor = true;
            // 
            // centeroidimage
            // 
            centeroidimage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            centeroidimage.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            centeroidimage.Location = new Point(447, 702);
            centeroidimage.Name = "centeroidimage";
            centeroidimage.Size = new Size(429, 59);
            centeroidimage.TabIndex = 8;
            centeroidimage.Text = "CENTEROID IMAGE";
            centeroidimage.UseVisualStyleBackColor = true;
            centeroidimage.Click += centeroid_Click;
            // 
            // DetectColor
            // 
            DetectColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DetectColor.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DetectColor.Location = new Point(447, 635);
            DetectColor.Name = "DetectColor";
            DetectColor.Size = new Size(429, 61);
            DetectColor.TabIndex = 7;
            DetectColor.Text = "DETECT COLOR";
            DetectColor.UseVisualStyleBackColor = true;
            DetectColor.Click += DetectColor_Click_1;
            // 
            // detectShape
            // 
            detectShape.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            detectShape.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detectShape.Location = new Point(447, 566);
            detectShape.Name = "detectShape";
            detectShape.Size = new Size(429, 63);
            detectShape.TabIndex = 5;
            detectShape.Text = "DETECT SHAPE";
            detectShape.UseVisualStyleBackColor = true;
            detectShape.Click += detectShape_Click;
            // 
            // originalbutton
            // 
            originalbutton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            originalbutton.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            originalbutton.Location = new Point(447, 838);
            originalbutton.Name = "originalbutton";
            originalbutton.Size = new Size(429, 70);
            originalbutton.TabIndex = 3;
            originalbutton.Text = "Reset";
            originalbutton.UseVisualStyleBackColor = true;
            originalbutton.Click += originalbutton_Click;
            // 
            // importpic
            // 
            importpic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            importpic.Location = new Point(729, 9);
            importpic.Name = "importpic";
            importpic.Size = new Size(150, 28);
            importpic.TabIndex = 2;
            importpic.Text = "Import Picture";
            importpic.UseVisualStyleBackColor = true;
            importpic.Click += importpic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 1;
            label1.Text = "OUTPUT HERE:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Location = new Point(6, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(876, 517);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(432, 511);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(441, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 511);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 446);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.048724F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90.95128F));
            tableLayoutPanel3.Size = new Size(350, 468);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(344, 28);
            label3.TabIndex = 0;
            label3.Text = "Detected Shapes";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label15, 0, 6);
            tableLayoutPanel5.Controls.Add(label14, 0, 5);
            tableLayoutPanel5.Controls.Add(label13, 0, 4);
            tableLayoutPanel5.Controls.Add(label12, 0, 3);
            tableLayoutPanel5.Controls.Add(label11, 0, 2);
            tableLayoutPanel5.Controls.Add(label10, 0, 1);
            tableLayoutPanel5.Controls.Add(rectangle, 1, 1);
            tableLayoutPanel5.Controls.Add(triangle, 1, 2);
            tableLayoutPanel5.Controls.Add(circle, 1, 3);
            tableLayoutPanel5.Controls.Add(star, 1, 4);
            tableLayoutPanel5.Controls.Add(pentagon, 1, 5);
            tableLayoutPanel5.Controls.Add(oval, 1, 6);
            tableLayoutPanel5.Controls.Add(square, 1, 0);
            tableLayoutPanel5.Controls.Add(label9, 0, 0);
            tableLayoutPanel5.Location = new Point(3, 45);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 7;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 51.06383F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 48.93617F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel5.Size = new Size(344, 420);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 362);
            label15.Name = "label15";
            label15.Size = new Size(166, 58);
            label15.TabIndex = 13;
            label15.Text = "OVAL";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(3, 302);
            label14.Name = "label14";
            label14.Size = new Size(166, 60);
            label14.TabIndex = 12;
            label14.Text = "PENTAGON";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 242);
            label13.Name = "label13";
            label13.Size = new Size(166, 60);
            label13.TabIndex = 11;
            label13.Text = "STAR";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 183);
            label12.Name = "label12";
            label12.Size = new Size(166, 59);
            label12.TabIndex = 10;
            label12.Text = "CIRCLE";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 125);
            label11.Name = "label11";
            label11.Size = new Size(166, 58);
            label11.TabIndex = 9;
            label11.Text = "TRIANGLE";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 64);
            label10.Name = "label10";
            label10.Size = new Size(166, 61);
            label10.TabIndex = 8;
            label10.Text = "RECTANGLE";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rectangle
            // 
            rectangle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rectangle.Location = new Point(175, 67);
            rectangle.Multiline = true;
            rectangle.Name = "rectangle";
            rectangle.Size = new Size(166, 52);
            rectangle.TabIndex = 1;
            rectangle.TextAlign = HorizontalAlignment.Center;
            // 
            // triangle
            // 
            triangle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            triangle.Location = new Point(175, 128);
            triangle.Multiline = true;
            triangle.Name = "triangle";
            triangle.Size = new Size(166, 52);
            triangle.TabIndex = 2;
            triangle.TextAlign = HorizontalAlignment.Center;
            // 
            // circle
            // 
            circle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            circle.Location = new Point(175, 186);
            circle.Multiline = true;
            circle.Name = "circle";
            circle.Size = new Size(166, 52);
            circle.TabIndex = 3;
            circle.TextAlign = HorizontalAlignment.Center;
            // 
            // star
            // 
            star.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            star.Location = new Point(175, 245);
            star.Multiline = true;
            star.Name = "star";
            star.Size = new Size(166, 52);
            star.TabIndex = 4;
            star.TextAlign = HorizontalAlignment.Center;
            // 
            // pentagon
            // 
            pentagon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pentagon.Location = new Point(175, 305);
            pentagon.Multiline = true;
            pentagon.Name = "pentagon";
            pentagon.Size = new Size(166, 52);
            pentagon.TabIndex = 5;
            pentagon.TextAlign = HorizontalAlignment.Center;
            // 
            // oval
            // 
            oval.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            oval.Location = new Point(175, 365);
            oval.Multiline = true;
            oval.Name = "oval";
            oval.Size = new Size(166, 52);
            oval.TabIndex = 6;
            oval.TextAlign = HorizontalAlignment.Center;
            // 
            // square
            // 
            square.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            square.Location = new Point(175, 3);
            square.Multiline = true;
            square.Name = "square";
            square.Size = new Size(166, 58);
            square.TabIndex = 0;
            square.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(166, 64);
            label9.TabIndex = 7;
            label9.Text = "SQUARE";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.048724F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90.95128F));
            tableLayoutPanel2.Size = new Size(350, 428);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.7558136F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2441864F));
            tableLayoutPanel4.Controls.Add(yellow, 1, 3);
            tableLayoutPanel4.Controls.Add(blue, 1, 2);
            tableLayoutPanel4.Controls.Add(green, 1, 1);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label6, 0, 2);
            tableLayoutPanel4.Controls.Add(label7, 0, 3);
            tableLayoutPanel4.Controls.Add(red, 1, 0);
            tableLayoutPanel4.Controls.Add(label5, 0, 1);
            tableLayoutPanel4.Location = new Point(3, 41);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 48.7341766F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 51.2658234F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel4.Size = new Size(344, 384);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // yellow
            // 
            yellow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            yellow.Location = new Point(212, 302);
            yellow.Multiline = true;
            yellow.Name = "yellow";
            yellow.Size = new Size(129, 64);
            yellow.TabIndex = 8;
            yellow.TextAlign = HorizontalAlignment.Center;
            // 
            // blue
            // 
            blue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            blue.Location = new Point(212, 201);
            blue.Multiline = true;
            blue.Name = "blue";
            blue.Size = new Size(129, 74);
            blue.TabIndex = 7;
            blue.TextAlign = HorizontalAlignment.Center;
            // 
            // green
            // 
            green.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            green.Location = new Point(212, 99);
            green.Multiline = true;
            green.Name = "green";
            green.Size = new Size(129, 73);
            green.TabIndex = 6;
            green.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(203, 96);
            label4.TabIndex = 0;
            label4.Text = "RED";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 198);
            label6.Name = "label6";
            label6.Size = new Size(203, 101);
            label6.TabIndex = 2;
            label6.Text = "BLUE";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 299);
            label7.Name = "label7";
            label7.Size = new Size(203, 85);
            label7.TabIndex = 3;
            label7.Text = "YELLOW";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // red
            // 
            red.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            red.Location = new Point(212, 3);
            red.Multiline = true;
            red.Name = "red";
            red.Size = new Size(129, 70);
            red.TabIndex = 5;
            red.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 96);
            label5.Name = "label5";
            label5.Size = new Size(203, 102);
            label5.TabIndex = 1;
            label5.Text = "GREEN";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(344, 28);
            label2.TabIndex = 0;
            label2.Text = "Detected Colors";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 920);
            Controls.Add(splitContainer1);
            Name = "Form3";
            Text = "Shape and Color Detection";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button originalbutton;
        private Button importpic;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox square;
        private TextBox rectangle;
        private TextBox triangle;
        private TextBox circle;
        private TextBox star;
        private TextBox pentagon;
        private TextBox oval;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button detectShape;
        private Button DetectColor;
        private TextBox yellow;
        private TextBox blue;
        private TextBox green;
        private TextBox red;
        private Button centeroidimage;
        private Button areaimage;
        private Panel panel1;
        private Button embossbtn;
        private Button lssybttn;
        private Button alldrcttbttn;
        private Button hrntlvrtclbutton;
        private Button vertcalbttn;
        private Button horizontalbttn;
    }
}