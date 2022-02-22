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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //validation of first name
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Enter your name, please !");
            }
            else if (textBox1.Text.Length < 4)
            {
                MessageBox.Show("Name must be 4 characters at least !");
            }
            //validation of middle name
            if (textBox5.Text.Length == 0)
            {
                MessageBox.Show("Enter your name, please !");
            }
            else if (textBox5.Text.Length < 4)
            {
                MessageBox.Show("Name must be 4 characters at least !");
            }
            //validation of last name
            if (textBox6.Text.Length == 0)
            {
                MessageBox.Show("Enter your name, please !");
            }
            else if (textBox6.Text.Length < 4)
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
            //validation of confirm
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
                    string insertStr = @"insert into Student(studentfname, studentMname, studentlname, yearofstudy, std_password, std_Email)
                                        values(@stufname, @stumname, @stulname, @grade, @stupassword, @stuemail)";
                    SqlCommand cmd = new SqlCommand(insertStr, con);
                    SqlParameter fname = new SqlParameter("@stufname", textBox1.Text);
                    cmd.Parameters.Add(fname);
                    SqlParameter mname = new SqlParameter("@stumname", textBox5.Text);
                    cmd.Parameters.Add(mname);
                    SqlParameter lname = new SqlParameter("@stulname", textBox6.Text);
                    cmd.Parameters.Add(lname);
                    SqlParameter year = new SqlParameter("@grade", textBox7.Text);
                    cmd.Parameters.Add(year);
                    SqlParameter password = new SqlParameter("@stupassword", textBox2.Text);
                    cmd.Parameters.Add(password);
                    SqlParameter email = new SqlParameter("@stuemail", textBox3.Text);
                    cmd.Parameters.Add(email);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your account is successfully created !");
                }
                //catch
                //{
                //    MessageBox.Show("Your account is successfully created !");
                //}
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
