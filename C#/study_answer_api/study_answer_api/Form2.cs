using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_answer_api
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string txt)
        {
            InitializeComponent();
            label1.Text = txt;

            MessageBox.Show(Form1.myMessage);



        }

        public Form2(Form1 f)
        {
            InitializeComponent();
            label1.Text = f.txt_name.Text;
        }


    }
}
