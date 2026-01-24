using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Inventory_Management_Sys.Class_Files
{
    internal class Categories_Data
    {
        public int Id { set; get; } 
        public string Category { set; get; }
        public string Date { set; get; }
        public List<Categories_Data> All_Categories_Data()
        {
            List<Categories_Data> listData = new List<Categories_Data>();


            using (SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wasib\source\repos\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf;Integrated Security=True"))
            {
                connect.Open();

                string selectData = "SELECT * FROM Categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Categories_Data Cat_D = new Categories_Data();

                        Cat_D.Id = (int)reader["Id"];
                        Cat_D.Category = reader["Category"].ToString();
                        Cat_D.Date = reader["Date"].ToString();


                        listData.Add(Cat_D);

                    }
                    return listData;
                }
            }
        }
    }
}
