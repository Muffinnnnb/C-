using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			Random rnd = new Random();
			int[] lottonum = new int[7];
			Label[] labels = new Label[7];
			labels[0] = label1;
			labels[1] = label2;
			labels[2] = label3;
			labels[3] = label4;
			labels[4] = label5;
			labels[5] = label6;
			labels[6] = label7;

			int NUM = 7;
			int i = 0;



			for (i = 0; i < NUM; i++)
			{
				lottonum[i] = rnd.Next(45) + 1;

				for (int j = 0; j < i; j++)
				{ //중복확인
					if (lottonum[i] == lottonum[j])
					{
						i--; //중복 발생 시 i번째 난수 재생성
						break;
					}

				}
			}
			for (int k = 0; k < NUM; k++) //오름차순정렬
			{
				for (i = 0; i < NUM - 1; i++)
				{
					if (lottonum[i] > lottonum[i + 1])
					{
						int tmp = lottonum[i];
						lottonum[i] = lottonum[i + 1];
						lottonum[i + 1] = tmp;
					}
				}
			}

			i = 0;
			foreach (int item in lottonum)
			{
				if (item <= 10)
				{ labels[i].ForeColor = Color.Yellow; }
				if (item > 10 && item <= 21)
				{ labels[i].ForeColor = Color.Blue; }
				if (item > 21 && item <= 31)
				{ labels[i].ForeColor = Color.Red; }
				if (item > 31 && item <= 41)
				{ labels[i].ForeColor = Color.Black; }
				if (item > 41 && item <= 45)
				{ labels[i].ForeColor = Color.Green; }

				labels[i].Text = "" + item;
				i++;
			}





		}
    }
}
