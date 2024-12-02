namespace Здоровое_питание
{
    partial class Enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter));
            lhealthfood = new Label();
            SuspendLayout();
            // 
            // lhealthfood
            // 
            lhealthfood.AutoSize = true;
            lhealthfood.BackColor = Color.Tan;
            lhealthfood.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold | FontStyle.Italic);
            lhealthfood.ForeColor = Color.FromArgb(252, 241, 210);
            lhealthfood.Location = new Point(61, 449);
            lhealthfood.Name = "lhealthfood";
            lhealthfood.Size = new Size(519, 71);
            lhealthfood.TabIndex = 0;
            lhealthfood.Text = "Здоровое питание";
            lhealthfood.Click += lhealthfood_Click;
            // 
            // Enter
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(658, 1014);
            Controls.Add(lhealthfood);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Enter";
            Text = "Enter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lhealthfood;
    }
}