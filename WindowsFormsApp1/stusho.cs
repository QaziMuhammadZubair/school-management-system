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

namespace WindowsFormsApp1
{
    public partial class stusho : Form
    {
        public stusho()
        {
            InitializeComponent();
        }

        private void stusho_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Qazi Muhammad Zubair\Documents\vp\WindowsFormsApp1\WindowsFormsApp1\schadd.mdf; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from stuadd", con);
            cmd.ExecuteNonQuery();
            DataTable td = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(td);
            dataGridView1.DataSource = td;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Valid Registration number");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Qazi Muhammad Zubair\Documents\vp\WindowsFormsApp1\WindowsFormsApp1\schadd.mdf; Integrated Security = True"))
                {

                    string str = "SELECT * FROM stuadd WHERE Rollno = '" + int.Parse(textBox1.Text) + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = "";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Valid Roll No");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Qazi Muhammad Zubair\Documents\vp\WindowsFormsApp1\WindowsFormsApp1\schadd.mdf; Integrated Security = True"))
                {

                    string str = "DELETE FROM stuadd WHERE Rollno = '" + int.Parse(textBox1.Text) + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = "";
            }
            using (SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Qazi Muhammad Zubair\Documents\vp\WindowsFormsApp1\WindowsFormsApp1\schadd.mdf; Integrated Security = True"))
            {

                string str = "SELECT * FROM stuadd";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            stuup n = new stuup();
            n.Show();
        }
    }
}
