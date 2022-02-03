using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class DataManager
    {

        public static List<ParkingCar> Cars = new List<ParkingCar>();

        static DataManager()
        {
            Load();

        }
        public static void Load()
        {
            try
            {
                DBHelper.selectQuery();
                Cars.Clear();
                foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
                {
                    ParkingCar car = new ParkingCar();
                    car.ParkingSpot = int.Parse(item["parkingSpot"].ToString());
                    car.CarNumber = item["CarNumber"].ToString();
                    car.DriverName = item["DriverName"].ToString();
                    car.PhoneNumber = item["PhoneNumber"].ToString();
                    car.ParkingTime = item["ParkingTime"].ToString()=="" ? new DateTime() : DateTime.Parse(item["ParkingTime"].ToString());
                    Cars.Add(car);

                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }


        public static void Save(string parkingSportText, string carNumverText,
            string driverNameText, string phoneNumber, bool isRemone = false)
        {
            try
            {
                DBHelper.updateQuery(parkingSportText, carNumverText, driverNameText, phoneNumber, isRemone);
            }
            catch (Exception exceotion)
            {

                System.Windows.Forms.MessageBox.Show(exceotion.Message + Environment.NewLine + exceotion.StackTrace);
            }
        }

        public static void PrintLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("ParkingHistory");
            if (!di.Exists)
            {
                di.Create();
            }
            using(StreamWriter writer = new StreamWriter("ParkingHistory"+ "\\" + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }




    }
}
