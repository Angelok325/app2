namespace Здоровое_питание
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            loginfield = new TextBox();
            passfield = new TextBox();
            registrlabel = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = Color.FromArgb(252, 241, 210);
            button1.Location = new Point(235, 725);
            button1.Name = "button1";
            button1.Size = new Size(208, 71);
            button1.TabIndex = 0;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 30F, FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(252, 241, 210);
            label1.Location = new Point(57, 212);
            label1.Name = "label1";
            label1.Size = new Size(542, 113);
            label1.TabIndex = 1;
            label1.Text = "Авторизация";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(245, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(43, 560);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(43, 374);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 106);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // loginfield
            // 
            loginfield.Font = new Font("Times New Roman", 25.875F);
            loginfield.Location = new Point(187, 374);
            loginfield.Multiline = true;
            loginfield.Name = "loginfield";
            loginfield.Size = new Size(437, 86);
            loginfield.TabIndex = 5;
            // 
            // passfield
            // 
            passfield.Font = new Font("Times New Roman", 25.875F);
            passfield.Location = new Point(187, 560);
            passfield.Name = "passfield";
            passfield.Size = new Size(437, 87);
            passfield.TabIndex = 6;
            passfield.UseSystemPasswordChar = true;
            // 
            // registrlabel
            // 
            registrlabel.AutoSize = true;
            registrlabel.ForeColor = Color.FromArgb(252, 241, 210);
            registrlabel.Location = new Point(221, 821);
            registrlabel.Name = "registrlabel";
            registrlabel.Size = new Size(233, 32);
            registrlabel.TabIndex = 7;
            registrlabel.Text = "зарегестрироваться";
            registrlabel.Click += registrlabel_Click;
            // 
            // button2
            // 
            button2.Location = new Point(273, 909);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(658, 1014);
            Controls.Add(button2);
            Controls.Add(registrlabel);
            Controls.Add(passfield);
            Controls.Add(loginfield);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "login";
            MouseDown += login_MouseDown;
            MouseMove += login_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox loginfield;
        private TextBox passfield;
        private Label registrlabel;
        private Button button2;
    }
}