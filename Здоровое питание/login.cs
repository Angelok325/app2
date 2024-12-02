using Microsoft.Win32;
using MySql.Data.MySqlClient;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            this.passfield.AutoSize = false;
            this.passfield.Size = new Size(this.passfield.Size.Width, 86);
        }


        Point lastPoin;

        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoin.X;
                this.Top += e.Y - lastPoin.Y;
            }
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoin = new Point(e.X, e.Y);
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginfield.Text;
            String passUser = passfield.Text;


                     BD db = new BD();

                  DataTable table = new DataTable();

                     MySqlDataAdapter adapter = new MySqlDataAdapter();

                      MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE 'login' = @ul AND  'pass' = @up", db.getConnection());

                      command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser;
                     command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passUser;

                      adapter.SelectCommand = command;
                      adapter.Fill(table);


                      if (table.Rows.Count > 0)
                           MessageBox.Show("Yes");
                      else
                         MessageBox.Show("Пользователь не найден");

        }

        private void registrlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            regist registrForm = new regist();
            registrForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home home = new home();
            home.Show();
        }
    }
}
