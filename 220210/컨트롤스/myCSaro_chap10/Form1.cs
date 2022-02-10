using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCSaro_chap10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a= int.Parse(textBox1.Text);
                MessageBox.Show("a="+a);
            }
            catch(Exception ex)
            {
                //throw new Exception("쓰로");
            }
            finally
            {
                MessageBox.Show("무조건 실행");
            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
