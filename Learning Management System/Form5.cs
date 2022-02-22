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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            //sql code
        }

        private void cout_Click(object sender, EventArgs e)
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

        private void back_Click(object sender, EventArgs e)
        {
            Form4 openForm = new Form4();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }

        private void eval_Click(object sender, EventArgs e)
        {
            //sql code
        }
    }
}
