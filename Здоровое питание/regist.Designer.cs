namespace Здоровое_питание
{
    partial class regist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regist));
            surnamefield = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonregester = new Button();
            namefield = new TextBox();
            loginfield = new TextBox();
            passfield = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // surnamefield
            // 
            surnamefield.Font = new Font("Times New Roman", 22.875F);
            surnamefield.Location = new Point(50, 307);
            surnamefield.Multiline = true;
            surnamefield.Name = "surnamefield";
            surnamefield.Size = new Size(565, 86);
            surnamefield.TabIndex = 13;
            surnamefield.Enter += surnamefield_Enter;
            surnamefield.Leave += surnamefield_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(282, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 30F, FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(252, 241, 210);
            label1.Location = new Point(77, 121);
            label1.Name = "label1";
            label1.Size = new Size(526, 113);
            label1.TabIndex = 9;
            label1.Text = "Регистрация";
            // 
            // buttonregester
            // 
            buttonregester.FlatStyle = FlatStyle.Flat;
            buttonregester.Font = new Font("Segoe UI", 15F);
            buttonregester.ForeColor = Color.FromArgb(252, 241, 210);
            buttonregester.Location = new Point(117, 876);
            buttonregester.Name = "buttonregester";
            buttonregester.Size = new Size(420, 71);
            buttonregester.TabIndex = 8;
            buttonregester.Text = "Зарегестрироваться";
            buttonregester.UseVisualStyleBackColor = true;
            buttonregester.Click += buttonregester_Click;
            // 
            // namefield
            // 
            namefield.Font = new Font("Times New Roman", 25.875F);
            namefield.Location = new Point(50, 444);
            namefield.Multiline = true;
            namefield.Name = "namefield";
            namefield.Size = new Size(565, 86);
            namefield.TabIndex = 14;
            namefield.Enter += namefield_Enter;
            namefield.Leave += namefield_Leave;
            // 
            // loginfield
            // 
            loginfield.Font = new Font("Times New Roman", 25.875F);
            loginfield.Location = new Point(50, 598);
            loginfield.Multiline = true;
            loginfield.Name = "loginfield";
            loginfield.Size = new Size(565, 86);
            loginfield.TabIndex = 15;
            loginfield.Enter += loginfield_Enter;
            loginfield.Leave += loginfield_Leave;
            // 
            // passfield
            // 
            passfield.Font = new Font("Times New Roman", 25.875F);
            passfield.Location = new Point(50, 744);
            passfield.Multiline = true;
            passfield.Name = "passfield";
            passfield.Size = new Size(565, 86);
            passfield.TabIndex = 16;
            passfield.Enter += passfield_Enter;
            passfield.Leave += passfield_Leave;
            // 
            // button1
            // 
            button1.Location = new Point(261, 956);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 17;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // regist
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(658, 1014);
            Controls.Add(button1);
            Controls.Add(passfield);
            Controls.Add(loginfield);
            Controls.Add(namefield);
            Controls.Add(surnamefield);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(buttonregester);
            FormBorderStyle = FormBorderStyle.None;
            Name = "regist";
            Text = "regist";
            MouseDown += regist_MouseDown;
            MouseMove += regist_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registrlabel;
        private TextBox surnamefield;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonregester;
        private TextBox namefield;
        private TextBox loginfield;
        private TextBox passfield;
        private Button button1;
    }
}