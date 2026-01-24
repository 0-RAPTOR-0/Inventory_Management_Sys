using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cashier
{
    class OrdersData
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wasib\Source\Repos\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf;Integrated Security=True");

        public string CID { set; get; }
        public string PID { set; get; }
        public string PName { set; get; }
        public string category { set; get; }

        public string origprice { set; get; }

        public string QTY { set; get; }

        public string TotalPrice { set; get; }
        public string Date { set; get; }

        public List<OrdersData> allOrdersData()
        {


            List<OrdersData> ordersList = new List<OrdersData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    int custID = 0;
                    string selectCustData = "SELECT MAX(customer_id) FROM Orders";

                    using (SqlCommand cmd = new SqlCommand(selectCustData, connect))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);

                            if (temp == 0)
                            {
                                custID = 1;
                            }
                            else
                            {
                                custID = temp;
                            }

                        }
                        else
                        {
                            Console.WriteLine("No data found.");

                        }
                    }
                    string selectData = "SELECT * FROM Orders";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {

                        cmd.Parameters.AddWithValue("@cID", custID);

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            OrdersData odata = new OrdersData();

                            odata.CID = reader["customer_id"].ToString();    
                            odata.PID = reader["prod_id"].ToString();
                            odata.PName = reader["prod_name"].ToString();
                            odata.category = reader["category"].ToString();
                            odata.origprice = reader["orig_price"].ToString();
                            odata.QTY = reader["qty"].ToString();
                            odata.TotalPrice = reader["total_price"].ToString();
                            odata.Date = reader["order_date"].ToString();

                            ordersList.Add(odata);
                        }
                        reader.Close();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }

            }

            return ordersList;
        }
    }
}

