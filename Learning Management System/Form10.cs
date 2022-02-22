using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_management_system
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
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
            //if email exists in sql ( develop the code below with if conditions )
            MessageBox.Show("Check your e-mail to set a new password.");
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form9 openForm = new Form9();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }
        public void close(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
