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
    public partial class emup : Form
    {
        public emup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Qazi Muhammad Zubair\Documents\vp\WindowsFormsApp1\WindowsFormsApp1\schadd.mdf; Integrated Security = True");
            con.Open();
            int Id = int.Parse(TextBox1.Text);
            string Name = TextBox2.Text;
            string Fathername = TextBox3.Text;
            string Phoneno = TextBox4.Text;
            string Exp = TextBox5.Text;
            string Gender = string.Empty;
            if (radioButton1.Checked == true)
            {
                Gender = "Male";
            }
            if (radioButton2.Checked == true)
            {
                Gender = "Female";
            }
            string Qualification = TextBox6.Text;
            string Address = TextBox7.Text;

            SqlCommand cmd = new SqlCommand("Update emp set Name='" + Name + "',Fathername='" + Fathername + "',Phoneno='" + Phoneno + "',Exp='" + Exp + "',Gender='" + Gender + "',Qualification='" + Qualification + "',Address='" + Address + "'where Id = '" + Id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }
    }
}
