namespace Здоровое_питание
{
    partial class tvr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tvr));
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(188, 145);
            label2.Name = "label2";
            label2.Size = new Size(320, 50);
            label2.TabIndex = 16;
            label2.Text = "Творог с бананом";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(285, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 204);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(293, 271);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(327, 204);
            label3.Name = "label3";
            label3.Size = new Size(289, 37);
            label3.TabIndex = 19;
            label3.Text = "Состав / ингредиенты";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 251);
            label4.Name = "label4";
            label4.Size = new Size(277, 256);
            label4.TabIndex = 20;
            label4.Text = "Творог 150гр\r\nБананы 1шт\r\nМед 0,5 чайн.л.\r\nВанилин 0,5гр\r\nСметана 25гр\r\nГрецкий орех 0,5шт\r\nПесочные печенье 5гр \r\n\r\n";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(28, 510);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(605, 483);
            textBox1.TabIndex = 21;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(252, 241, 210);
            label1.Location = new Point(-4, -12);
            label1.Name = "label1";
            label1.Size = new Size(61, 65);
            label1.TabIndex = 22;
            label1.Text = "<";
            label1.Click += label1_Click;
            // 
            // tvr
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(658, 1014);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "tvr";
            Text = "tvr";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
    }
}