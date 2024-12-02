using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Здоровое_питание
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            blin blin = new blin();
            blin.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            tvr tvr = new tvr();
            tvr.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            omlet omlet = new omlet();
            omlet.Show();
        }

        

       
    }
}
