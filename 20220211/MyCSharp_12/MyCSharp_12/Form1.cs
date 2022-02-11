using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyCSharp_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> list = new List<string>() { "이동준", "김동진", "김지환", "박재형", "민경환", "송성수", "채예진" };

            //이름이 이동준인 사람 찾기
            //linq는 var로 받아오게 되어 있음
            var ldj = from item in list where item == "이동준" select item;
            label1.Text = ldj.ToList()[0];  //ldj[0].ToString();

            List<string> output = new List<string>();
            foreach (var item in list)
            {
                if (item == "이동준")
                    output.Add(item);
            }
            label1.Text += "_" + output[0];



        }

        //배열을 입력받아서, 그 배열에 있는 짝수만 반환함
        public int[] SelectEven(int[] input)
        {
            return (from item in input where item % 2 == 0 select item).ToArray<int>();
        }
        public  List<int> SelectEven(List<int> input)
        {
            return (from item in input where item % 2 == 0 select item).ToList<int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] input = new int[] {1, 2, 3, 4, 5, 6, 7};
            List<int> inputList = new List<int>() {1, 2, 3, 4, 5, 6, 7};

            int[] output = SelectEven(input);
            List<int> myoutput = SelectEven(inputList);


            label2.Text = "";
            label3.Text = "";

            foreach (var item in output)
            {
               label2.Text+="_" + item;
            }
            foreach(var item in myoutput)
            {
                label3.Text += "_" + item;
            }

            output[0] = -100; //output에 있는 거 바꾼다고 영향끼치지 않음. linq쓰면 복사가 잘 됨!(깊은 복사!!!)
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

            //배열이랑 리스트도 참조복사를 씀. 주의해야 함!

            int[] outputtest = output;
            outputtest[0] = -100;
            foreach (var item in output) //output이 아닌 outputtest의 0번째꺼 값 바꿨는데 output의 첫번째에 -100들어감.
            {
                Console.WriteLine(item);
            }


        }

        List<Product> products = new List<Product>();

        private void button2_Click(object sender, EventArgs e)
        {
            //생성자 없이, 바로 멤버변수에 값 넣는 거...
            Product product = new Product() { Name=textBox1.Text, Price=int.Parse(textBox2.Text)};
            products.Add(product);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            foreach (var item in products)
            {
                label4.Text += "제품명 " + item.Name + ", 가격 : " + item.Price + Environment.NewLine;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            
            var output = from item in products where item.Price < 1500 orderby item.Price ascending select item;
            foreach(var item in output)
            {
                Console.WriteLine(item);//만약 ToString이 구현되어 있다면 구체적인 값이 나온다.
                //내부적으로는 Console.WriteLine(item.ToString()) 이다.
                label5.Text += "제품명 " + item.Name + ", 가격 : " + item.Price + Environment.NewLine;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string url = "https://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement xElement = XElement.Load(url);
            Console.WriteLine(xElement);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string url = "https://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement xElement = XElement.Load(url);
            //Console.WriteLine(xElement);
            var output = from item in xElement.Descendants("data") select item;
            //Descendants xml의 모든 "data" 태그 선택

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string url = "https://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement xElement = XElement.Load(url);
            //Console.WriteLine(xElement);
            var output = from item in xElement.Descendants("data") select item;
            //Descendants xml의 모든 "data" 태그 선택

            foreach (var item in output)
            {
                Console.WriteLine(item.Element("day").Value);
                Console.WriteLine(item.Element("wfKor").Value);
                Console.WriteLine(item.Element("wfEn").Value);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string url = "https://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement xElement = XElement.Load(url);
            //Console.WriteLine(xElement);
            var output = from item in xElement.Descendants("data") select new 
            {
                Day = item.Element("day").Value,
                weather_kor = item.Element("wfKor").Value,
                weather_eng = item.Element("wfEn").Value
            };
            //Descendants xml의 모든 "data" 태그 선택

            foreach (var item in output)
            {
                Console.WriteLine(item.Day);
                Console.WriteLine(item.weather_kor);
                Console.WriteLine(item.weather_eng);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string url = "https://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement xElement = XElement.Load(url);
            //Console.WriteLine(xElement);
            var output = from item in xElement.Descendants("data")
                         select new Weather()
                         {
                             Day = item.Element("day").Value,
                             weather_kor = item.Element("wfKor").Value,
                             weather_eng = item.Element("wfEn").Value
                         };
            //Descendants xml의 모든 "data" 태그 선택

            foreach (var item in output)
            {
                Console.WriteLine(item.Day);
                Console.WriteLine(item.weather_kor);
                Console.WriteLine(item.weather_eng);
            }
        }

        //Linq 없이
        private void button10_Click(object sender, EventArgs e)
        {
            string url = "https://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement xElement = XElement.Load(url);

            List<Weather> weathers = new List<Weather>();

            foreach (var item in xElement.Descendants("data"))
            {
                Weather weather = new Weather();
                weather.Day = item.Element("day").Value;
                weather.weather_kor = item.Element("wfKor").Value;
                weather.weather_eng = item.Element("wfEn").Value;
                weathers.Add(weather);
            }

            foreach (Weather weather in weathers)
            {
                Console.WriteLine(weather.Day);
                Console.WriteLine(weather.weather_kor);
                Console.WriteLine(weather.weather_eng);
            }

        }
    }
}
