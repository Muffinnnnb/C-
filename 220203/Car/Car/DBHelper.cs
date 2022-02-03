using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class DBHelper
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;


        public static void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0}); " +
                "initial Catalog = {1};" +
                "Integrated Security={2};" +
                "Timeout=3",
                "local", "MYDB1", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        
        public static void selectQuery(int parkingSpot = -1)    //selectQuery() 디폴트값이 -1로 들어감
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (parkingSpot < 0)
            {
                cmd.CommandText = "SELECT*FROM CarManager";
            }
            else
            {
                cmd.CommandText = "SELECT*FROM CarManager where ParkingSpot = "+parkingSpot;
            }

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds,"CarManager");






            conn.Close();

        }

        public static void insertQuery(int parkingSpot)
        {

            try
            {
                ConnectDB();

                string sqlcommand = "Insert into CarManager(parkingSpot) values(@p1)";
                SqlCommand cmd = new SqlCommand(sqlcommand);

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;


                cmd.Parameters.AddWithValue("@p1", parkingSpot);

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();


                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message+Environment.NewLine+ex.StackTrace);
            }

        }

        public static void updateQuery(string parkingSportText, string carNumverText,
            string driverNameText, string phoneNumber,bool isRemone = false)
        {
            try
            {
                string sqlcommand;


                ConnectDB();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;


                
                if (isRemone)
                {
                    sqlcommand = "update CarManager set CarNumber='', DriverName='', phoneNumber='', parkingTime=null  where ParkingSpot=@p1";
                    cmd.Parameters.AddWithValue("@p1", parkingSportText);
                }
                else
                {
                    sqlcommand = "update CarManager set CarNumber=@p1,DriverName=@p2,phoneNumber=@p3,parkingTime=@p4  where ParkingSpot=@p5";
                    cmd.Parameters.AddWithValue("@p1", carNumverText);
                    cmd.Parameters.AddWithValue("@p2", driverNameText);
                    cmd.Parameters.AddWithValue("@p3", phoneNumber);
                    cmd.Parameters.AddWithValue("@p4", DateTime.Now.ToString("yyy-MM-dd HH:mm:ss.fff"));
                    cmd.Parameters.AddWithValue("@p5", parkingSportText);
                }


                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch(Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }








    }












}
