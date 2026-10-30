using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TextBox1.Text == "user" && TextBox2.Text == "123")
            {
                Menu a = new Menu();
                a.Show();
            }
            else
                MessageBox.Show("Error");
        }
    }
}
