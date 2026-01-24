using Inventory_Management_Sys.Class_Files;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Management_Sys.User_Control_Forms
{
    public partial class Cashier_Order_Form : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wasib\source\repos\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf;Integrated Security=True");

        public Cashier_Order_Form()
        {
            InitializeComponent();

            displayallAvailableProducts();
            displayAll_Categories();

        }

        public void displayallAvailableProducts()
        {
            Products_Data Pro_D = new Products_Data();
            List<Products_Data> listData = Pro_D.allAvailableProducts();

            DataGridView1.DataSource = listData;
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayAll_Categories()
        {
            if (!checkConnection())
            {


                try
                {
                    connect.Open();

                    string seletcData = "SELECT * FROM Categories ";

                    using (SqlCommand cmd = new SqlCommand(seletcData, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cashierOrder_Catagroy.Items.Clear();

                            while (reader.Read())
                            {
                                string item = reader.GetString(1);
                                cashierOrder_Catagroy.Items.Add(item);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR CONNECTION ! " + ex, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cashierOrder_Catagroy_SelectedIndexChanged(object sender, EventArgs e)
        {

            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodID.Items.Clear();
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
            cashierOrder_qty.Value = 0;


            string selectedValue = cashierOrder_Catagroy.SelectedItem as string;

            if (selectedValue != null)
            {
                if (checkconnection())
                {
                    try
                    {
                        connect.Open();
                        string seletctData = $"SELECT * FROM Products WHERE Category = '{selectedValue}' AND Status = @Status ";

                        using (SqlCommand cmd = new SqlCommand(seletctData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["Product_ID"].ToString();
                                    cashierOrder_prodID.Items.Add(value);
                                }
                            }
                        }
                    }
                    catch (exception ex)
                    {
                        MessageBox.Show("ERROR CONNECTION ! " + ex, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private bool checkconnection()
        {
            throw new NotImplementedException();
        }

        private void cashierOrder_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = cashierOrder_prodID.SelectedItem as string;

            if (checkConnection())
                if (selectedValue != null)
                {

                    try
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM products WHERE Product_ID = '{selectedValue}' AND status = @status";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["Product_Name"].ToString(); 
                                    float prodPrice = Convert.ToSingle(reader["Price"]);

                                    cashierOrder_prodName.Text = prodName;
                                    cashierOrder_price.Text = prodPrice.ToString("0.00");
                                }
                            }

                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        connect.Close();
                    }

                }
        }

        private void cashierOrder_addBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
