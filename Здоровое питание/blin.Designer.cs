namespace Здоровое_питание
{
    partial class blin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blin));
            label1 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(252, 241, 210);
            label1.Location = new Point(-12, -21);
            label1.Name = "label1";
            label1.Size = new Size(61, 65);
            label1.TabIndex = 29;
            label1.Text = "<";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(357, 186);
            label3.Name = "label3";
            label3.Size = new Size(289, 37);
            label3.TabIndex = 26;
            label3.Text = "Состав / ингредиенты";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 223);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(293, 271);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(288, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(212, 136);
            label2.Name = "label2";
            label2.Size = new Size(226, 50);
            label2.TabIndex = 23;
            label2.Text = "Овсяноблин";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 223);
            label5.Name = "label5";
            label5.Size = new Size(344, 352);
            label5.TabIndex = 30;
            label5.Text = resources.GetString("label5.Text");
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(30, 578);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(597, 424);
            textBox1.TabIndex = 31;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // blin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(658, 1014);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "blin";
            Text = "blin";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label5;
        private TextBox textBox1;
    }
}