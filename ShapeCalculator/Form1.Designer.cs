namespace ShapeCalculator
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            WidthL = new Label();
            LengthL = new Label();
            DepthL = new Label();
            ShapeL = new Label();
            DimensionL = new Label();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2D", "3D" });
            comboBox1.Location = new Point(600, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(600, 244);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            comboBox2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(63, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(63, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // WidthL
            // 
            WidthL.AutoSize = true;
            WidthL.Location = new Point(82, 168);
            WidthL.Name = "WidthL";
            WidthL.Size = new Size(39, 15);
            WidthL.TabIndex = 5;
            WidthL.Text = "Width";
            // 
            // LengthL
            // 
            LengthL.AutoSize = true;
            LengthL.Location = new Point(76, 90);
            LengthL.Name = "LengthL";
            LengthL.Size = new Size(44, 15);
            LengthL.TabIndex = 6;
            LengthL.Text = "Length";
            // 
            // DepthL
            // 
            DepthL.AutoSize = true;
            DepthL.Location = new Point(82, 244);
            DepthL.Name = "DepthL";
            DepthL.Size = new Size(39, 15);
            DepthL.TabIndex = 7;
            DepthL.Text = "Depth";
            // 
            // ShapeL
            // 
            ShapeL.AutoSize = true;
            ShapeL.Location = new Point(627, 198);
            ShapeL.Name = "ShapeL";
            ShapeL.Size = new Size(39, 15);
            ShapeL.TabIndex = 8;
            ShapeL.Text = "Shape";
            // 
            // DimensionL
            // 
            DimensionL.AutoSize = true;
            DimensionL.Location = new Point(627, 44);
            DimensionL.Name = "DimensionL";
            DimensionL.Size = new Size(52, 15);
            DimensionL.TabIndex = 9;
            DimensionL.Text = "2D or 3D";
            // 
            // button1
            // 
            button1.Location = new Point(345, 198);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 173);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 11;
            label1.Text = "Answer: ?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(DimensionL);
            Controls.Add(ShapeL);
            Controls.Add(DepthL);
            Controls.Add(LengthL);
            Controls.Add(WidthL);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label WidthL;
        private Label LengthL;
        private Label DepthL;
        private Label ShapeL;
        private Label DimensionL;
        private Button button1;
        private Label label1;
    }
}