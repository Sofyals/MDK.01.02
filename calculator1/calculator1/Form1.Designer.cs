namespace calculator1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labe = new Label();
            label1 = new Label();
            man = new PictureBox();
            woman = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            height = new TextBox();
            weight = new TextBox();
            g = new PictureBox();
            trackBar1 = new TrackBar();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button3 = new Button();
            t = new PictureBox();
            n = new PictureBox();
            x = new PictureBox();
            label8 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            dress = new PictureBox();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)man).BeginInit();
            ((System.ComponentModel.ISupportInitialize)woman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)g).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n).BeginInit();
            ((System.ComponentModel.ISupportInitialize)x).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dress).BeginInit();
            SuspendLayout();
            // 
            // labe
            // 
            labe.AutoSize = true;
            labe.Font = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            labe.Location = new Point(475, 46);
            labe.Name = "labe";
            labe.Size = new Size(356, 49);
            labe.TabIndex = 0;
            labe.Text = "BMI калькулятор";
            labe.Click += labe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 220);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 1;
            // 
            // man
            // 
            man.Image = (Image)resources.GetObject("man.Image");
            man.Location = new Point(141, 173);
            man.Name = "man";
            man.Size = new Size(182, 264);
            man.SizeMode = PictureBoxSizeMode.Zoom;
            man.TabIndex = 4;
            man.TabStop = false;
            man.Click += pictureBox1_Click;
            // 
            // woman
            // 
            woman.Image = (Image)resources.GetObject("woman.Image");
            woman.Location = new Point(396, 173);
            woman.Name = "woman";
            woman.Size = new Size(199, 267);
            woman.SizeMode = PictureBoxSizeMode.Zoom;
            woman.TabIndex = 5;
            woman.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(246, 546);
            label4.Name = "label4";
            label4.Size = new Size(77, 32);
            label4.TabIndex = 8;
            label4.Text = "Рост:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(259, 667);
            label5.Name = "label5";
            label5.Size = new Size(64, 32);
            label5.TabIndex = 9;
            label5.Text = "Вес:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(451, 546);
            label6.Name = "label6";
            label6.Size = new Size(42, 32);
            label6.TabIndex = 10;
            label6.Text = "см";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(451, 667);
            label7.Name = "label7";
            label7.Size = new Size(35, 32);
            label7.TabIndex = 11;
            label7.Text = "кг";
            // 
            // button1
            // 
            button1.Location = new Point(137, 766);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 12;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(405, 766);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 13;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // height
            // 
            height.Location = new Point(341, 543);
            height.Name = "height";
            height.Size = new Size(82, 39);
            height.TabIndex = 14;
            height.TextChanged += textBox1_TextChanged;
            // 
            // weight
            // 
            weight.Location = new Point(341, 664);
            weight.Name = "weight";
            weight.Size = new Size(82, 39);
            weight.TabIndex = 15;
            // 
            // g
            // 
            g.Image = (Image)resources.GetObject("g.Image");
            g.Location = new Point(890, 147);
            g.Name = "g";
            g.Size = new Size(304, 376);
            g.SizeMode = PictureBoxSizeMode.Zoom;
            g.TabIndex = 16;
            g.TabStop = false;
            g.Visible = false;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = SystemColors.Control;
            trackBar1.Cursor = Cursors.PanSouth;
            trackBar1.Location = new Point(673, 581);
            trackBar1.Maximum = 60;
            trackBar1.Minimum = 10;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(661, 90);
            trackBar1.TabIndex = 18;
            trackBar1.Value = 31;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(608, 664);
            label9.Name = "label9";
            label9.Size = new Size(187, 32);
            label9.TabIndex = 19;
            label9.Text = "Недостаточный";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(785, 699);
            label10.Name = "label10";
            label10.Size = new Size(126, 32);
            label10.TabIndex = 20;
            label10.Text = "Здоровый";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(879, 667);
            label11.Name = "label11";
            label11.Size = new Size(157, 32);
            label11.TabIndex = 21;
            label11.Text = "Избыточный";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1084, 667);
            label12.Name = "label12";
            label12.Size = new Size(132, 32);
            label12.TabIndex = 22;
            label12.Text = "Ожирение";
            // 
            // button3
            // 
            button3.Location = new Point(1157, 793);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 24;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // t
            // 
            t.Image = (Image)resources.GetObject("t.Image");
            t.Location = new Point(899, 147);
            t.Name = "t";
            t.Size = new Size(304, 376);
            t.SizeMode = PictureBoxSizeMode.Zoom;
            t.TabIndex = 25;
            t.TabStop = false;
            t.Visible = false;
            // 
            // n
            // 
            n.Image = (Image)resources.GetObject("n.Image");
            n.Location = new Point(890, 157);
            n.Name = "n";
            n.Size = new Size(304, 376);
            n.SizeMode = PictureBoxSizeMode.Zoom;
            n.TabIndex = 26;
            n.TabStop = false;
            n.Visible = false;
            // 
            // x
            // 
            x.Image = (Image)resources.GetObject("x.Image");
            x.Location = new Point(890, 147);
            x.Name = "x";
            x.Size = new Size(304, 376);
            x.SizeMode = PictureBoxSizeMode.Zoom;
            x.TabIndex = 27;
            x.TabStop = false;
            x.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(998, 546);
            label8.Name = "label8";
            label8.Size = new Size(83, 32);
            label8.TabIndex = 28;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(255, 192, 128);
            label13.ForeColor = Color.FromArgb(255, 192, 128);
            label13.Location = new Point(687, 628);
            label13.Name = "label13";
            label13.Size = new Size(144, 32);
            label13.TabIndex = 29;
            label13.Text = "label13";
            // 
            // label14
            // 
            label14.BackColor = Color.ForestGreen;
            label14.ForeColor = Color.White;
            label14.Location = new Point(830, 628);
            label14.Name = "label14";
            label14.Size = new Size(66, 32);
            label14.TabIndex = 30;
            // 
            // label15
            // 
            label15.BackColor = Color.FromArgb(255, 192, 128);
            label15.ForeColor = Color.FromArgb(255, 192, 128);
            label15.Location = new Point(890, 628);
            label15.Name = "label15";
            label15.Size = new Size(68, 32);
            label15.TabIndex = 31;
            label15.Text = "label15";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.BackColor = Color.Red;
            label16.ForeColor = Color.FromArgb(255, 192, 128);
            label16.Location = new Point(953, 628);
            label16.Name = "label16";
            label16.Size = new Size(365, 32);
            label16.TabIndex = 32;
            // 
            // dress
            // 
            dress.Image = (Image)resources.GetObject("dress.Image");
            dress.Location = new Point(890, 157);
            dress.Name = "dress";
            dress.Size = new Size(304, 376);
            dress.SizeMode = PictureBoxSizeMode.Zoom;
            dress.TabIndex = 33;
            dress.TabStop = false;
            dress.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(164, 462);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 36;
            button4.Text = "Мужской";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(424, 462);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 37;
            button5.Text = "Женский";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(715, 763);
            label2.Name = "label2";
            label2.Size = new Size(116, 45);
            label2.TabIndex = 38;
            label2.Text = "label2";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 885);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dress);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(x);
            Controls.Add(n);
            Controls.Add(t);
            Controls.Add(button3);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(trackBar1);
            Controls.Add(g);
            Controls.Add(weight);
            Controls.Add(height);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(woman);
            Controls.Add(man);
            Controls.Add(label1);
            Controls.Add(labe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)man).EndInit();
            ((System.ComponentModel.ISupportInitialize)woman).EndInit();
            ((System.ComponentModel.ISupportInitialize)g).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)t).EndInit();
            ((System.ComponentModel.ISupportInitialize)n).EndInit();
            ((System.ComponentModel.ISupportInitialize)x).EndInit();
            ((System.ComponentModel.ISupportInitialize)dress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labe;
        private Label label1;
        private PictureBox man;
        private PictureBox woman;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private TextBox height;
        private TextBox weight;
        private PictureBox g;
        private TrackBar trackBar1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button3;
        private PictureBox t;
        private PictureBox n;
        private PictureBox x;
        private Label label8;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private PictureBox dress;
        private Button button4;
        private Button button5;
        private Label label2;
    }
}