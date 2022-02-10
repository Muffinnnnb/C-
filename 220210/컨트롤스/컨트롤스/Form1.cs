using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Button = System.Windows.Forms.Button;

namespace 컨트롤스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button btn = new Button();
            btn.Text = "클릭";

            Point p = new Point(100,100);
            btn.Location = p;


            btn.Click += Btn_Click;

            Controls.Add(btn);


            foreach (var item in Controls)
            {
                Console.WriteLine(item.ToString());
            }


        }

        private void Btn_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (var item in Controls)
            {
                if(item is CheckBox)
                {
                    if((item as CheckBox).Checked)
                    list.Add((item as CheckBox).Text);
                }


                //var temp = item as CheckBox;
                //if(temp != null)
                    //list.Add((item as CheckBox).Text);
            }
            MessageBox.Show(String.Join(",",list));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string my_meal="";
            foreach (var items in Controls)
            {
                if(items is GroupBox)
                {
                    foreach(var item in (items as GroupBox).Controls)
                    {
                        if(item is RadioButton)
                        {
                            if ((item as RadioButton).Checked)
                                my_meal += (item as RadioButton).Text + " ";                        }
                    }

                }
                if(items is Panel)
                {
                    foreach (var item in (items as GroupBox).Controls)
                    {
                        if (item is RadioButton)
                        {
                            var temp = item as RadioButton;
                            if(temp != null)
                            {
                                if ((temp).Checked)
                                    my_meal += (temp).Text + " ";
                            }
                        }
                    }
                }
                


            }
            MessageBox.Show(my_meal);
        }
    }
}
