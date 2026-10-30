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
    public partial class emad : Form
    {
        public emad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Qazi Muhammad Zubair\Documents\vp\WindowsFormsApp1\WindowsFormsApp1\schadd.mdf; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into emp values (@Id,@Name,@Fathername,@Phoneno,@Exp,@Gender,@Qualification,@Address)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@Name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Fathername", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Phoneno", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Exp", TextBox5.Text);

            if (radioButton1.Checked == true)
            {
                cmd.Parameters.AddWithValue("@Gender", radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                cmd.Parameters.AddWithValue("@Gender", radioButton2.Text);
            }
            cmd.Parameters.AddWithValue("@Qualification", TextBox6.Text);
            cmd.Parameters.AddWithValue("@Address", TextBox7.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }
    }
}
