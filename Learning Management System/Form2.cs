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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void login_Click(object sender, EventArgs e)
        {
                Form4 openForm = new Form4();
                openForm.Show();
                this.Hide();
                openForm.FormClosing += close;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 openForm = new Form1();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
