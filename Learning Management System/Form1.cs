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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void instructor_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        public void close(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void student_Click(object sender, EventArgs e)
        {
            Form7 openForm = new Form7();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }

        private void add_Click(object sender, EventArgs e)
        {

            Form12 openForm = new Form12();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Form13 openForm = new Form13();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }

        private void update_Click(object sender, EventArgs e)
        {
            Form14 openForm = new Form14();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }
    }
}
