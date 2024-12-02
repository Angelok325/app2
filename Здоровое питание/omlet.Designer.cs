namespace Здоровое_питание
{
    partial class omlet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(omlet));
            textBox1 = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(34, 565);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(597, 424);
            textBox1.TabIndex = 38;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 227);
            label5.Name = "label5";
            label5.Size = new Size(408, 320);
            label5.TabIndex = 37;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(252, 241, 210);
            label1.Location = new Point(-2, -16);
            label1.Name = "label1";
            label1.Size = new Size(61, 65);
            label1.TabIndex = 36;
            label1.Text = "<";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(353, 190);
            label3.Name = "label3";
            label3.Size = new Size(289, 37);
            label3.TabIndex = 35;
            label3.Text = "Состав / ингредиенты";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 227);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(293, 271);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(273, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F, FontStyle.Italic);
            label4.Location = new Point(59, 140);
            label4.Name = "label4";
            label4.Size = new Size(583, 50);
            label4.TabIndex = 39;
            label4.Text = "Миш-маш (омлет по-болгарски)";
            // 
            // omlet
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(658, 1014);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "omlet";
            Text = "omlet";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label5;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label4;
    }
}