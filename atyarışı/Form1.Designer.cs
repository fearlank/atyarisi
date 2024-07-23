namespace atyarışı
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(-267, -1);
            label1.Name = "label1";
            label1.Size = new Size(1302, 16);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(-267, 110);
            label2.Name = "label2";
            label2.Size = new Size(1302, 16);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(-267, 219);
            label3.Name = "label3";
            label3.Size = new Size(1302, 16);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(-267, 330);
            label4.Name = "label4";
            label4.Size = new Size(1302, 16);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(12, 384);
            button1.Name = "button1";
            button1.Size = new Size(167, 74);
            button1.TabIndex = 4;
            button1.Text = "BAŞLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ddomi44_ed040be4_2be4_40e8_b488_921539700807;
            pictureBox1.Location = new Point(1, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Muybridge_race_horse___big_transp;
            pictureBox2.Location = new Point(1, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.running_horse;
            pictureBox3.Location = new Point(1, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(1030, -1);
            label5.Name = "label5";
            label5.Size = new Size(57, 347);
            label5.TabIndex = 8;
            // 
            // label6
            // 
            label6.BackColor = Color.Yellow;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(203, 384);
            label6.Name = "label6";
            label6.Size = new Size(832, 111);
            label6.TabIndex = 9;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Black;
            label7.Font = new Font("Segoe UI", 20F);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(1060, 384);
            label7.Name = "label7";
            label7.Size = new Size(154, 111);
            label7.TabIndex = 10;
            label7.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1246, 504);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
