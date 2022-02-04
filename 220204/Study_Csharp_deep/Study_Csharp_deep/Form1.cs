using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Csharp_deep
{
    public partial class Form1 : Form
    {

        enum Rock_Scissor_Paper
        {
            GAWI,BAWI=1,BO
        }




        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            FormClosed += FormClosed_;

            button_bawi.Click += RSP_Click;
            button_gawi.Click += RSP_Click;
            button_bo.Click += RSP_Click;
        }

        private void RSP_Click(object sender, EventArgs e)
        {

            int pc = new Random().Next(3);

            int mychoice;

            Button b = (sender as Button);

            string myresult= b.Name.Split('_')[1].ToUpper();

            if(myresult== "GAWI")
                mychoice = 0;
            else if (myresult=="BAWI")
                mychoice = 1;
            else 
                mychoice = 2;

            switch ((Rock_Scissor_Paper)mychoice)
            {
                case Rock_Scissor_Paper.GAWI:
                    switch (pc)
                    {
                        case (int)Rock_Scissor_Paper.GAWI:
                            MessageBox.Show("비김");
                            break;
                        case (int)Rock_Scissor_Paper.BAWI:
                            MessageBox.Show("짐");
                            break;
                        case (int)Rock_Scissor_Paper.BO:
                            MessageBox.Show("이김");
                            break;

                    }


                    break;

                case Rock_Scissor_Paper.BAWI:
                    switch (pc)
                    {
                        case (int)Rock_Scissor_Paper.GAWI:
                            MessageBox.Show("이김");
                            break;
                        case (int)Rock_Scissor_Paper.BAWI:
                            MessageBox.Show("비김");
                            break;
                        case (int)Rock_Scissor_Paper.BO:
                            MessageBox.Show("짐");
                            break;

                    }

                    break ;
                case Rock_Scissor_Paper.BO:
                    switch (pc)
                    {
                        case (int)Rock_Scissor_Paper.GAWI:
                            MessageBox.Show("짐");
                            break;
                        case (int)Rock_Scissor_Paper.BAWI:
                            MessageBox.Show("이김");
                            break;
                        case (int)Rock_Scissor_Paper.BO:
                            MessageBox.Show("비김");
                            break;

                    }



                    break ;

                default:
                    break;
            }

            MessageBox.Show("내꺼 =" + mychoice + ", 컴터 =" + pc);
            MessageBox.Show("내꺼 =" + (Rock_Scissor_Paper)mychoice + ", 컴터 =" + (Rock_Scissor_Paper)pc);

        }

        private void FormClosed_(object s, EventArgs e)
        {
            //MessageBox.Show("직접 만든 close 이벤트");
        }
        private void Button1_Click(object s,EventArgs e)
        {
            MessageBox.Show("직접 만든 버튼 이벤트");

        }


        private void swap(int a, int b)
        {
            int temp = a;
            a= b;
            b= temp;

        }
        private void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;


        }

        private int[] study_out(out int a, out int b)
        {
            a = 100;
            b = 200;
            
            return new int[2]{1,2 };
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            swap(a, b);
            MessageBox.Show("a="+a+", b="+b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // int a = int.Parse(textBox1.Text);
            //int b = int.Parse(textBox2.Text);
            //swap(ref a, ref b);
           // MessageBox.Show("a=" + a + ", b=" + b);


            int c = 0;
            int d = -1;
            int[] result = study_out(out c, out d);

            MessageBox.Show("c=" + result[0] + ", d=" + result[1]);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Parent parent = new Parent();

            parent.Id = 1;

            parent.Method();

            parent.Method2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Child child = new Child();

            child.Id = "일";
            child.Method();
            child.Method2();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Child pc = new Child();

            ((Parent)pc).Id = 1;
            ((Parent)pc).Method();
            ((Parent)pc).Method2();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Parent KDJ = new Parent();
            KDJ.Id = 100;

            Parent LDJ = KDJ;

            LDJ.Id = -456;

            MessageBox.Show("KDJ의 ID = "+ KDJ.Id);
            MessageBox.Show("LDJ의 ID = " + LDJ.Id);

        }
        void Increase(Parent p)
        {
            p.Id++;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Parent p=new Parent();
            p.Id = 500;
            Increase(p);
            MessageBox.Show("p.Id = "+p.Id);
        }
    }
}
