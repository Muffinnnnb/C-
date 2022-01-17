using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yy = Convert.ToInt32(DateTime.Now.ToString("yyyy"))- Convert.ToInt32(textBox1.Text)+1;
            MessageBox.Show("생년: " + yy);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
