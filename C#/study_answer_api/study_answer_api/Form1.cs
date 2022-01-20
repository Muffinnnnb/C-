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
    public partial class Form1 : Form
    {


        public static string myMessage;


        int answer;

        Label[] labels;


        public Form1()
        {

            InitializeComponent();

            answer = new Random().Next(10) + 1;

            labels = new Label[7];
            labels = new Label[] { label1, label2, label3, label4, label5, label6, label7 };
            foreach(Label i in labels)
            {
                i.Text = "";
            }






            //Controls는 form 상의 버튼, 텍스트박스 등이 담겨잇는 리스트
            foreach (var item in Controls)
            {
                if(item is Button)
                {
                    if ((item as Button).Name.Contains("btn_answer"))
                        (item as Button).Click += Answer_Button_Click;
                }
            }

            

        }


        private void Answer_Button_Click(object sender, EventArgs e)
        {
            int.TryParse((sender as Button).Text, out int num);
            if (num <= 0)
            {
                MessageBox.Show("잘못된 값을 넣음!");
            }
            if (num == answer)
            {
                MessageBox.Show("정답!~!" + num);
                answer = new Random().Next(10)+1;

            }
            else
            {
                MessageBox.Show("컴="+ answer+" 나="+ num);
            }
        }

        private void Lotto_(Label item)
        {
            int.TryParse((item as Label).Text, out int value);
            if (value <= 10)
            {
                item.ForeColor = Color.Yellow;
                item.BackColor = Color.Black;
            }
            else if (value <= 20)
                item.ForeColor = Color.Blue;
            else if (value <= 30)
                item.ForeColor = Color.Black;
            else
                item.ForeColor = Color.Green;
        }



        private void btn_info_Click(object sender, EventArgs e)
        {
            


            MessageBox.Show($" 이름: {txt_name.Text}, 나이: {txt_age.Text}, 성별: {txt_gender.Text}");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            myMessage = txt_name.Text + txt_age.Text + txt_gender.Text;
            new Form2(txt_name.Text + txt_age.Text + txt_gender.Text).Show();

            
        }

        private void txt_gender_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool B=int.TryParse(textBox1.Text, out int value);
            if (B)
            {
                MessageBox.Show($"{DateTime.Now.Year + 1 - value}");
            }
            else
            {
                MessageBox.Show("숫자로 입력하세요!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int computerNum = new Random().Next(10)+1;
            if (int.TryParse(textBox2.Text, out int value))
            {
                if(value == computerNum)
                    MessageBox.Show("정답!");
                else
                    MessageBox.Show("value="+value+" pc="+ computerNum);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] lotto = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Random random = new Random();
                int num = random.Next(45) + 1;
                if (lotto.Contains(num))
                    i--;
                else
                    lotto[i] = num;
            }
            Array.Sort(lotto);
            for(int i = 0; i<lotto.Length; i++)
            {
                labels[i].Text = lotto[i].ToString();
            }


            

            foreach (Label item in labels)
            {
                Lotto_(item);
            }
        }
    }
}
