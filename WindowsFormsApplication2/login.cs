using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                button4.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (txtPassword.PasswordChar == '\0')
            {
                button3.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("User Name and Password are required");
            }
            else
            {
                if (txtUsername.Text == "pablo" && txtPassword.Text == "pablo1")
                {
                    Dashboard DashboardForm = new Dashboard();
                    this.Hide();
                    DashboardForm.Show();
                }
                else
                {
                    MessageBox.Show("Password doesn't match Username");
                }
            }

            //DBconnection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //string connectionString = ("datasource=localhost;username=root;password=;database=dues_payment");

        //public void DBconnection()
        //{
        //    string query = "SELECT * FROM login  WHERE username= '" + txtUsername.Text + " 'AND password= ' " + txtPassword.Text + "'";

        //    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        //    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

        //    commandDatabase.CommandTimeout = 5;
        //    MySqlDataReader reader;
        //    reader = commandDatabase.ExecuteReader();


        //    databaseConnection.Open();
          

        //    try
        //    {

        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                MessageBox.Show("Login to Dashboard");
        //                Dashboard frm2 = new Dashboard();
        //                frm2.Show();
        //                this.Hide();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Oops! Something went wrong. Please try again later");
        //        }
        //        databaseConnection.Close();

        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }


        }
    }










//public string ConnectionString { get; set; }
    

