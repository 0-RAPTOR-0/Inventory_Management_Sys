using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management_Sys.Class_Files
{
    class CustomersData
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True");
        private string customer_iD;

        public string customerID { set; get; }
        public string prod_id { set; get; }
        public string total_price { set; get; }

        public string amount_ { set; get; }
        public string change { set; get; }

        public string order_date { set; get; }


        public List<CustomersData> AllCustomers()
        {
            List<CustomersData> listDtate = new List<CustomersData>();

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();

                    string selectData = "SELECT * FROM customers WHERE order_date @order_date";

                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@order_date", order_date);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomersData cust = new CustomersData();

                            cust.customer_iD = reader["customer_iD"].ToString();
                            cust.prod_id = reader["prod_id"].ToString();
                            cust.total_price = reader["total_price"].ToString();
                            cust.amount_ = reader["amount_"].ToString();
                            cust.change = reader["change"].ToString();
                            cust.order_date = reader["order_date"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed connection " + ex);

                }
                finally
                {
                    con.Close();
                }
            }

            return listDtate;

        }

    }
}
