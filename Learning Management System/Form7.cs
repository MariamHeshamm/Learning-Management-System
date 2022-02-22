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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
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

        private void register_Click(object sender, EventArgs e)
        {
            Form8 openForm = new Form8();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }

        private void login_Click(object sender, EventArgs e)
        {
            Form9 openForm = new Form9();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }
    }
}
