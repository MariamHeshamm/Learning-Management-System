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

namespace Learning_Management_System
{
    public partial class LoginForm : Form
    {
        // sql connection
        public string conString = "Data Source=DESKTOP-KSM113G;Initial Catalog=LearningManagementSystem;Integrated Security=True";
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new  SqlConnection(conString);
            con.Open();
            if(con.State==System.Data.ConnectionState.Open)
            {
                MessageBox.Show("connection made successfuly...!");
            }
        }

        public LoginForm()
        {
            InitializeComponent();

            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 50);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
