using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();

            try
            {
                textBox_parkingSpot.Text = DataManager.Cars[0].ParkingSpot.ToString();
                textBox_carNum.Text = DataManager.Cars[0].CarNumber.ToString();
                textBox_name.Text = DataManager.Cars[0].DriverName.ToString();
                textBox_phoneNum.Text = DataManager.Cars[0].PhoneNumber.ToString();
            }
            catch (Exception ex)
            {
                DataManager.PrintLog("초기데이터 없음");
               // DataManager.PrintLog(Text.Empty);
               // DataManager.PrintLog(Text);
                //throw;
            }
            dataGridView_parkingManager.DataSource = DataManager.Cars;
        }

        public List<ParkingCar> tests = new List<ParkingCar>();

        private void button_parkingAdd_Click(object sender, EventArgs e)
        {
            if(textBox_parkingSpot.Text.Trim() =="")
                MessageBox.Show("주차공간 입력하시오");
            else if(textBox_carNum.Text.Trim() == "")
                MessageBox.Show("차넘버 입력하시오");
            else
            {
                try
                {
                    ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_parkingSpot.Text);
                    if(car.CarNumber.Trim() != "")
                    {
                        MessageBox.Show("해당 공ㄴ간에 이미 차가 있습니다.");
                    }
                    else
                    {
                        car.CarNumber = textBox_carNum.Text;
                        car.DriverName = textBox_name.Text;
                        car.PhoneNumber= textBox_phoneNum.Text;
                        car.ParkingTime = DateTime.Now;


                        dataGridView_parkingManager.DataSource = null;
                        dataGridView_parkingManager.DataSource = DataManager.Cars;
                        DataManager.Save(textBox_parkingSpot.Text, textBox_phoneNum.Text, textBox_name.Text, textBox_phoneNum.Text);

                    }
                }
                catch (Exception ex)
                {
                    string contents = $"주차공간 {textBox_parkingSpot}은(는) 없습니다.";
                    MessageBox.Show(contents);
                    throw;
                }
            }

        }

        private void button_parkingRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
