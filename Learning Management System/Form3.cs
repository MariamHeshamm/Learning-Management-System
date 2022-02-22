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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //validation of name
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Enter your name, please !");
            }
            else if (textBox1.Text.Length < 4)
            {
                MessageBox.Show("Name must be 4 characters at least !");
            }
            //validation of e-mail
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
            
            //confirm password
            if (textBox4.Text.Length == 0)
            {
                MessageBox.Show("Confirm password, please !");
            }
            else if (textBox4.Text != textBox2.Text)
            {
                MessageBox.Show("It is not the same password you entered before !");
            }
            //creating account
            else 
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-0H4VTQ3SQLEXPRESS;Initial Catalog=Learning Management system 2;Integrated Security=True");
                con.Open();
                try
                {
                    string insertStr = @"insert into Instructor(inst_name, inst_Email, inst_password)
                                       values(@instructorName, @instructorEmail, @instructorPassword)";
                    SqlCommand cmd = new SqlCommand(insertStr, con);
                    SqlParameter paraminstructorname = new SqlParameter("@instructorName", textBox1.Text);
                    cmd.Parameters.Add(paraminstructorname);
                    SqlParameter paraminstructoremail = new SqlParameter("@instructorEmail", textBox3.Text);
                    cmd.Parameters.Add(paraminstructoremail);
                    SqlParameter paraminstructorpass = new SqlParameter("@instructorPassword", textBox2.Text);
                    cmd.Parameters.Add(paraminstructorpass);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your account is successfully created !");
                }
                catch
                {
                    MessageBox.Show("Something went wrong ! Try later, please");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }
        public void close(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
