using System.Collections.Generic;
using System.Data.SqlClient;


namespace Inventory_Management_Sys.Class_Files
{
    internal class Products_Data
    {
        public int Id { set; get; }
        public string Product_ID { set; get; }
        public string Product_Name { set; get; }
        public string Category { set; get; }
        public string Price { set; get; }
        public string Stock { set; get; }
        public string Status { set; get; }
        public string Date_Insert { set; get; }
        public string Image_Path { set; get; }

        public List<Products_Data> All_Products()
        {
            List<Products_Data> listData = new List<Products_Data>();


            using (SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\AIUB\New folder\C#\Lab\Project\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM Products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Products_Data Pro_D = new Products_Data();

                        Pro_D.Id = (int)reader["Id"];
                        Pro_D.Product_ID = reader["Product_ID"].ToString();
                        Pro_D.Product_Name = reader["Product_Name"].ToString();
                        Pro_D.Category = reader["Category"].ToString();
                        Pro_D.Price = reader["Price"].ToString();
                        Pro_D.Stock = reader["Stock"].ToString();   
                        Pro_D.Status = reader["Status"].ToString();
                        Pro_D.Date_Insert = reader["Date_Insert"].ToString();
                        Pro_D.Image_Path = reader["Image_Path"].ToString();

                        listData.Add(Pro_D);

                    }
                    return listData;
                }
            }
        }
    }
}
