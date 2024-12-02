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
using static System.Windows.Forms.DataFormats;

namespace Здоровое_питание
{
    public partial class regist : Form
    {
        public regist()
        {
            InitializeComponent();

            namefield.Text = "Введите имя";
            namefield.ForeColor = Color.Gray;

            surnamefield.Text = "Введите фамилию";
            surnamefield.ForeColor = Color.Gray;

            loginfield.Text = "Введите логин";
            loginfield.ForeColor = Color.Gray;

            passfield.Text = "Введите пароль";
            passfield.ForeColor = Color.Gray;


        }

        Point lastPoin;

        private void regist_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoin.X;
                this.Top += e.Y - lastPoin.Y;
            }
        }

        private void regist_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoin = new Point(e.X, e.Y);
        }

        private void surnamefield_Enter(object sender, EventArgs e)
        {
            if (surnamefield.Text == "Введите фамилию")
                surnamefield.Text = "";
            surnamefield.ForeColor = Color.Black;
        }

        private void surnamefield_Leave(object sender, EventArgs e)
        {
            if (surnamefield.Text == "")
                surnamefield.Text = "Введите фамилию";
            surnamefield.ForeColor = Color.Black;
        }

        private void namefield_Leave(object sender, EventArgs e)
        {
            if (namefield.Text == "")
                namefield.Text = "Введите имя";
            namefield.ForeColor = Color.Black;
        }

        private void namefield_Enter(object sender, EventArgs e)
        {
            if (namefield.Text == "Введите имя")
                namefield.Text = "";
            namefield.ForeColor = Color.Black;
        }

        private void loginfield_Enter(object sender, EventArgs e)
        {
            if (loginfield.Text == "Введите логин")
                loginfield.Text = "";
            loginfield.ForeColor = Color.Black;
        }

        private void loginfield_Leave(object sender, EventArgs e)
        {
            if (loginfield.Text == "")
                loginfield.Text = "Введите логин";
            loginfield.ForeColor = Color.Black;
        }

        private void passfield_Enter(object sender, EventArgs e)
        {
            if (passfield.Text == "Введите пароль")
                passfield.Text = "";
            passfield.ForeColor = Color.Black;
        }

        private void passfield_Leave(object sender, EventArgs e)
        {
            if (passfield.Text == "")
                passfield.Text = "Введите пароль";
            passfield.ForeColor = Color.Black;
        }

        private void buttonregester_Click(object sender, EventArgs e)
        {
            if (namefield.Text == "Введите имя")
            {


                MessageBox.Show("Введите имя");
                return;
            }


            if (surnamefield.Text == "")
            {

                MessageBox.Show("Введите фамилию");
                return;
            }

                    if (isuserExists())
                       return;
            
                 BD bd = new BD();
               MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname);", bd.getConnection());
            
             command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginfield.Text;
                       command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passfield.Text;
                     command.Parameters.Add("@namen", MySqlDbType.VarChar).Value = namefield.Text;
                   command.Parameters.Add("@username", MySqlDbType.VarChar).Value = surnamefield.Text;
            

                 bd.openConnection();

               if (command.ExecuteNonQuery() == 1)
                     MessageBox.Show("Аккаунт был создан");
               else
                 MessageBox.Show("Аккаунт не был создан");

                        bd.closeConnection();
        }


        public Boolean isuserExists()
        {

                  BD db = new BD();

            DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

               MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE 'login' = @ul ", db.getConnection());

              command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginfield.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;

            }

            else
                return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home home = new home();
            home.Show();
        }

        
    }
}
