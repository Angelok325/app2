namespace Здоровое_питание
{
    partial class kabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kabinet));
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            Фамилия = new DataGridViewTextBoxColumn();
            Имя = new DataGridViewTextBoxColumn();
            Логин = new DataGridViewTextBoxColumn();
            Пароль = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(273, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Фамилия, Имя, Логин, Пароль });
            dataGridView1.Location = new Point(1, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(660, 715);
            dataGridView1.TabIndex = 26;
            // 
            // Фамилия
            // 
            Фамилия.HeaderText = "Фамилия";
            Фамилия.MinimumWidth = 10;
            Фамилия.Name = "Фамилия";
            Фамилия.Width = 200;
            // 
            // Имя
            // 
            Имя.HeaderText = "Имя";
            Имя.MinimumWidth = 10;
            Имя.Name = "Имя";
            Имя.Width = 200;
            // 
            // Логин
            // 
            Логин.HeaderText = "Логин";
            Логин.MinimumWidth = 10;
            Логин.Name = "Логин";
            Логин.Width = 200;
            // 
            // Пароль
            // 
            Пароль.HeaderText = "Пароль";
            Пароль.Name = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(252, 241, 210);
            label1.Location = new Point(99, 141);
            label1.Name = "label1";
            label1.Size = new Size(454, 75);
            label1.TabIndex = 27;
            label1.Text = "Личный кабинет";
            // 
            // kabinet
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(658, 1014);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kabinet";
            Text = "kabinet";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Фамилия;
        private DataGridViewTextBoxColumn Имя;
        private DataGridViewTextBoxColumn Логин;
        private DataGridViewTextBoxColumn Пароль;
        private Label label1;
    }
}