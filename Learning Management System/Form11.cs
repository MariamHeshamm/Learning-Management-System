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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
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
            Form9 openForm = new Form9();
            openForm.Show();
            this.Hide();
            openForm.FormClosing += close;
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0H4VTQ3SQLEXPRESS;Initial Catalog=Learning Management system 2;Integrated Security=True");
            con.Open();
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Enter the your ID, please !");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("show__data_m", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Student_id", textBox3.Text));
                    //SqlParameter param = cmd.Parameters.Add("@Student_id", SqlDbType.Int);
                    //param.Direction = ParameterDirection.Output;
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    //table.Columns.Add("ID");
                    table.Columns.Add("First name");
                    table.Columns.Add("Middle name");
                    table.Columns.Add("Last name");
                    table.Columns.Add("Grade");
                    table.Columns.Add("Degree");
                    table.Columns.Add("Course name");

                    DataRow row;
                    while(reader.Read())
                    {
                        row = table.NewRow();
                        //row["Id"] = reader["ID"];
                        row["First name"] = reader["studentfname"];
                        row["Middle name"] = reader["studentMname"];
                        row["Last name"] = reader["studentlname"];
                        row["Grade"] = reader["yearofstudy"];
                        row["Degree"] = reader["stud_degree"];
                        row["Course name"] = reader["coursename"];
                        table.Rows.Add(row);
                    }
                    reader.Close();

                    dataGridView1.DataSource = table;
                }
                //catch
                //{
                //    MessageBox.Show("Something went wrong ! Try again later, please");
                //}
                finally
                {
                    con.Close();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
