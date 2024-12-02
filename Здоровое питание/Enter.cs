using Microsoft.VisualBasic.Logging;
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
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void healthfood_Click(object sender, EventArgs e)
        {


        }

        private void lhealthfood_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginform = new login();
            loginform.Show();
        }
    }
}
