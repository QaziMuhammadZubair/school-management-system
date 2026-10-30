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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            addmission b = new addmission();
            b.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            stusho f = new stusho();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emad q = new emad();
            q.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emsho w = new emsho();
            w.Show();
        }
    }
}
