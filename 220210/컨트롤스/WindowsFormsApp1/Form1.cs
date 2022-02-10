using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {












        delegate void TestDel();


        delegate int MyAdd(int x, int y);



        void Hello()
        {
            MessageBox.Show("hi");
        }










        public Form1()
        {
            InitializeComponent();
        }

        void threeTime(TestDel a)
        {
            for(int i = 0; i < 3; i++)
            {
               
                a();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            TestDel t = Hello;
            t();
            threeTime(t);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            threeTime(delegate () { MessageBox.Show("Test"); });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            threeTime(() => { MessageBox.Show("람다"); });
        }

        void ShowResult(MyAdd m, int a, int b)
        {
            MessageBox.Show("두 변수 합" + m(a,b) + "이다");
        }

        int custom_add(int a, int b)
        {
            if (a < 0)
                a *= -1;
            if (b < 0)
                b *= -1;
            return a+b;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            MyAdd m = custom_add;
            m(10, -10);
            ShowResult(m,10,-10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowResult(delegate (int a, int b) { return a + b; }, 10, -100);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowResult((int a, int b) =>  { return a*2 + b; }, 10, -100);
        }

        void method1()
        {
            for (int i = 0; i < 10; i++) {Console.Write("a");}

        }


        private void button7_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(method1);
            Thread t2 = new Thread(delegate () { for (int i = 0; i < 100; i++) { Console.Write("b"); } });
            Thread t3= new Thread(() =>{ for (int i = 0; i < 100; i++) { Console.Write("c"); } });

            Console.WriteLine("일반");
            method1();
            TestDel bb = delegate () { for (int i = 0; i < 100; i++) { Console.Write("b"); } };
            TestDel cc = ()=> { for (int i = 0; i < 100; i++) { Console.Write("c"); } };
            bb();
            cc();

            Console.WriteLine("\n\n\n\n 쓰레드 활용");
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
