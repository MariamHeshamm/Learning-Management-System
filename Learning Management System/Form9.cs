using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Learning_management_system
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            //validation of email
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Enter your e-mail, please !");
            }
            else if (!textBox3.Text.Contains("@") || !textBox3.Text.Contains(".com"))
            {
                MessageBox.Show("Enter a valid e-mail, please !");
            }
            //validation of password
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Enter a password, please !");
            }
            //else if (textBox2.Text.Length < 8)
            //{
            //    MessageBox.Show("Password must be 8 characters at least !");
            //}
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-0H4VTQ3SQLEXPRESS;Initial Catalog=Learning Management system 2;Integrated Security=True");
                con.Open();
                try
                {
                    string query = $"select count(*) from Student where std_Email='{textBox3.Text}'and std_password='{textBox2.Text}'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result == 1)
                    {
                        MessageBox.Show("Welcome !");
                        Form11 openForm = new Form11();
                        openForm.Show();
                        this.Hide();
                        openForm.FormClosing += close;
                    }
                    else
                    {
                        MessageBox.Show("E-mail or password is wrong !");
                    }
                }
                catch
                {
                    MessageBox.Show("Someting went wrong ! Try again later, please");

                }
                finally
                {
                    con.Close();

                }
            }


        }

        private void back_Click(object sender, EventArgs e)
        {
            Form7 openForm = new Form7();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }
        public void close(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void forget_Click(object sender, EventArgs e)
        {
            Form10 openForm = new Form10();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
