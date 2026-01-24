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

            displayAll_Products();
            displayAll_Categories();

        }

        public void displayAll_Products()
        {
            Products_Data Pro_D = new Products_Data();
            List<Products_Data> listData = Pro_D.All_Products();

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
            if (checkConnection())
            {


                try
                {
                    connect.Open();

                    string seletcData = "SELECT * FROM Categories ";

                    using (SqlCommand cmd = new SqlCommand(seletcData, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cashierOrder_Categroy.Items.Clear();

                            while (reader.Read())
                            {
                                string item = reader.GetString(1);
                                cashierOrder_Categroy.Items.Add(item);
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
            // Clear the Product ID list first so it doesn't keep old items
            cashierOrder_prodID.Items.Clear();
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
            cashierOrder_qty.Value = 0;

            string selectedValue = cashierOrder_Categroy.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                    }

                    // This query finds IDs based on the category you just picked
                    string selectData = "SELECT Product_ID FROM Products WHERE Category = @Category AND Status = @Status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@Category", selectedValue);
                        cmd.Parameters.AddWithValue("@Status", "Available");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // This line adds the IDs to your ComboBox
                                cashierOrder_prodID.Items.Add(reader["Product_ID"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }



        private int idGen;
        public void IDGenerator()
        {
            // Fix: The original code had a semicolon at the end of the 'using' line which was a bug
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wasib\source\repos\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf;Integrated Security=True"))
            {
                connect.Open();

                // Fix: Added "FROM Orders" to the query
                string selectData = "SELECT MAX(customer_id) FROM Orders";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        int temp = Convert.ToInt32(result);
                        idGen = temp + 1;
                    }
                    else
                    {
                        idGen = 1;
                    }
                }
            }

            }

        private void cashierOrder_addBtn_Click_1(object sender, EventArgs e)
        {
            IDGenerator();

            if (cashierOrder_Categroy.SelectedIndex == -1 || cashierOrder_prodID.SelectedIndex == -1 ||
                string.IsNullOrEmpty(cashierOrder_prodName.Text) || string.IsNullOrEmpty(cashierOrder_price.Text) ||
                cashierOrder_qty.Value == 0)
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                    }

                    float getPrice = 0;
                    string selectOrder = "SELECT Price FROM products WHERE Product_ID = @Product_ID";
                    using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                    {
                        getOrder.Parameters.AddWithValue("@Product_ID", cashierOrder_prodID.SelectedItem);
                        object rawValue = getOrder.ExecuteScalar();
                        if (rawValue != null && rawValue != DBNull.Value)
                        {
                            getPrice = Convert.ToSingle(rawValue);
                        }
                    }

                    // Fixed the INSERT statement column/parameter match
                    string insertdata = @"INSERT INTO Orders 
                (customer_id, prod_id, prod_name, category, qty, orig_price, total_price, order_date) 
                VALUES 
                (@cID, @prodID, @prodName, @cat, @qty, @origPrice, @totalPrice, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                    {
                        float totalP = getPrice * (float)cashierOrder_qty.Value;

                        cmd.Parameters.AddWithValue("@cID", idGen);
                        cmd.Parameters.AddWithValue("@prodID", cashierOrder_prodID.SelectedItem);
                        cmd.Parameters.AddWithValue("@prodName", cashierOrder_prodName.Text.Trim());
                        cmd.Parameters.AddWithValue("@cat", cashierOrder_Categroy.SelectedItem);
                        cmd.Parameters.AddWithValue("@qty", cashierOrder_qty.Value);
                        cmd.Parameters.AddWithValue("@origPrice", getPrice);
                        cmd.Parameters.AddWithValue("@totalPrice", totalP);
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cashierOrder_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashierOrder_prodID.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                    }

                    string selectData = "SELECT Product_Name, Price FROM Products WHERE Product_ID = @ProdID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@ProdID", selectedValue);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cashierOrder_prodName.Text = reader["Product_Name"].ToString();
                                decimal price = Convert.ToDecimal(reader["Price"]);
                                cashierOrder_price.Text = price.ToString("0.00");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

        
