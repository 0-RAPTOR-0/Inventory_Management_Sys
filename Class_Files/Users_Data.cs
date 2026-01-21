using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_Sys.Class_Files
{
    internal class Users_Data
    {
        public int Id { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string Role { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }

        public List<Users_Data> All_Users_Data()
        {
            List<Users_Data> listData = new List<Users_Data>();


            using (SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\AIUB\New folder\C#\Lab\Project\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM Users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Users_Data Users_D = new Users_Data();

                        Users_D.Id = (int)reader["Id"];
                        Users_D.UserName = reader["UserName"].ToString();
                        Users_D.Password = reader["Password"].ToString();
                        Users_D.Role = reader["Role"].ToString();
                        Users_D.Status = reader["Status"].ToString();
                        Users_D.Date = reader["Date"].ToString();

                        listData.Add(Users_D);

                    }
                    return listData;
                }
            }
        }
    }
}
