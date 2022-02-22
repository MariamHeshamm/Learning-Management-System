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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //fname validation
            if(textBox1.Text.Length==0)
            {
                MessageBox.Show("First name is empty.");
            }
            else if (textBox5.Text.Length == 0)
            {
                MessageBox.Show("Middle name is empty.");
            }
            else if (textBox6.Text.Length == 0)
            {
                MessageBox.Show("Last name is empty.");
            }
            else if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("E-mail is empty.");
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Password is empty.");
            }
            else if (textBox7.Text.Length == 0)
            {
                MessageBox.Show("Grade is empty.");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-0H4VTQ3SQLEXPRESS;Initial Catalog=Learning Management system 2;Integrated Security=True");
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("adding", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@studentfname", textBox1.Text));
                    cmd.Parameters.Add(new SqlParameter("@studentMname", textBox5.Text));
                    cmd.Parameters.Add(new SqlParameter("@studentlname", textBox6.Text));
                    cmd.Parameters.Add(new SqlParameter("@yearofstudy", textBox7.Text));
                    cmd.Parameters.Add(new SqlParameter("@std_password", textBox2.Text));
                    cmd.Parameters.Add(new SqlParameter("@std_Email", textBox3.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("A new student is successfully added !");
                }
                catch
                {
                    MessageBox.Show("Something went wrong ! Try again later, please");
                }
                finally
                {
                    con.Close();
                }
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 openForm = new Form1();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }
        public void close(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
