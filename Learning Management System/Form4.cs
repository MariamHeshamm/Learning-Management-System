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
    public partial class Form4 : Form
    {
        private const int V = 1;

        public Form4()
        {
            InitializeComponent();
        }

        [Obsolete]
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
            else if (textBox2.Text.Length < 8)
            {
                MessageBox.Show("Password must be 8 characters at least !");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-0H4VTQ3SQLEXPRESS;Initial Catalog=Learning Management system 2;Integrated Security=True");
                con.Open();
                try
                {
                    string query = $"select count(*) from Instructor where inst_Email='{textBox3.Text}'and inst_password='{textBox2.Text}'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result==1)
                    {
                        MessageBox.Show("Welcome !");
                        Form5 openForm = new Form5();
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
        public void close(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }

        private void forget_Click(object sender, EventArgs e)
        {
            Form6 openForm = new Form6();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
