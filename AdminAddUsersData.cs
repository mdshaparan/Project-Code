using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HMS
{
    internal class AdminAddUsersData
    {
        SqlConnection Conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\7th Semester\C Sharp\HMS\HMS\Hspital.mdf"";Integrated Security=True;");

        public int ID { get; set; }
        public string Username { set; get; } 
        public string Password { set; get; } 
        public string Role { set; get; }
        public string Image {  set; get; }
        public string Status { set; get; }
        public string Date_Registered { set; get; }

        public List<AdminAddUsersData> usersListData()
        {
            List<AdminAddUsersData> listData = new List<AdminAddUsersData> ();
            if (Conn1.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    Conn1.Open ();
                    string selectData = "SELECT * FROM Users";
                    SqlCommand cmd = new SqlCommand (selectData,Conn1);
                   SqlDataReader reader = cmd.ExecuteReader ();

                    while (reader.Read ())
                    {

                        AdminAddUsersData userData = new AdminAddUsersData ();
                        userData.ID = (int)reader["id"];
                        userData.Username = reader["username"].ToString();
                        userData.Password = reader["password"].ToString();
                        userData.Role = reader["role"].ToString();
                        userData.Image = reader["Profile_Image"].ToString();
                        userData.Status = reader["status"].ToString();
                        userData.Date_Registered = reader["Reg_Date"].ToString();

                        listData.Add (userData);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed: " + ex);
                }
                finally
                {
                    Conn1.Close ();
                }
            }
            return listData;
        }

    }
}
