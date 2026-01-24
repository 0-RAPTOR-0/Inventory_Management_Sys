using Cashier;
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
            displayAllOrders();

            calculateTotal();
        }

        public void calculateTotal()
        {
            double total = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                if (row.Cells["TotalPrice"].Value != null)
                {
                    total += Convert.ToDouble(row.Cells["TotalPrice"].Value);
                }
            }


            cashierOrder_totalprice.Text = total.ToString("0.00");
        }
        public void displayAll_Products()
        {
            Products_Data Pro_D = new Products_Data();
            List<Products_Data> listData = Pro_D.All_Products();

            DataGridView1.DataSource = listData;
        }
        public void displayAllOrders()
        {
            OrdersData O_Data = new OrdersData();
            List<OrdersData> listData = O_Data.allOrdersData();

            dataGridView2.DataSource = listData;
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


                    string selectData = "SELECT Product_ID FROM Products WHERE Category = @Category AND Status = @Status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@Category", selectedValue);
                        cmd.Parameters.AddWithValue("@Status", "Available");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

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
        private object cashierOrder_totalPrice;

        public void IDGenerator()
        {

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wasib\source\repos\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf;Integrated Security=True"))
            {
                connect.Open();


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
                        displayAllOrders();
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
            displayAllOrders();

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

        public void ClearFields()
        {
            cashierOrder_Categroy.SelectedIndex = -1;
            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodID.Items.Clear();
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
            cashierOrder_qty.Value = 0;
        }

        private void cashierOrder_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cashierOrder_removeBtn_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    string prodID = dataGridView2.SelectedRows[0].Cells["PID"].Value.ToString();
                    string customerID = dataGridView2.SelectedRows[0].Cells["CID"].Value.ToString();

                    if (MessageBox.Show("Are you sure you want to remove Product ID: " + prodID + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            if (connect.State == ConnectionState.Closed) { connect.Open(); }

                            string deleteData = "DELETE FROM Orders WHERE prod_id = @prodID AND customer_id = @cID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@prodID", prodID);
                                cmd.Parameters.AddWithValue("@cID", customerID);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            displayAllOrders();
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
                else
                {
                    MessageBox.Show("Please select a row in the All Orders table first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cashierOrder_amount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cashierOrder_amount.Text))
            {
                cashierOrder_change.Text = "0.00";
                return;
            }

            try
            {
                double total = 0;
                double amount = 0;


                if (double.TryParse(cashierOrder_totalprice.Text, out total))
                {
                    if (double.TryParse(cashierOrder_amount.Text, out amount))
                    {
                        double change = amount - total;

                        cashierOrder_change.Text = (change >= 0) ? change.ToString("0.00") : "0.00";
                    }
                }
            }
            catch
            {
                cashierOrder_change.Text = "0.00";
            }
        }

        private void cashierOrder_payOrders_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cashierOrder_amount.Text) || dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Please add items and enter an amount first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double total = Convert.ToDouble(cashierOrder_totalprice.Text);
                double amount = Convert.ToDouble(cashierOrder_amount.Text);

                if (amount < total)
                {
                    MessageBox.Show("Insufficient amount provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Confirm payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Payment Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cashierOrder_amount.Text = "";
                        cashierOrder_change.Text = "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cashierOrder_receipt_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0 || string.IsNullOrEmpty(cashierOrder_amount.Text))
            {
                MessageBox.Show("No transaction found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string receipt = "------------------------------------------\n";
            receipt += "          SUPERMARKET RECEIPT             \n";
            receipt += "------------------------------------------\n";
            receipt += "Date: " + DateTime.Now.ToString() + "\n\n";
            receipt += string.Format("{0,-15} {1,-10} {2,-10}\n", "Item", "Qty", "Price");

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["PName"].Value != null)
                {
                    receipt += string.Format("{0,-15} {1,-10} {2,-10}\n",
                        row.Cells["PName"].Value, row.Cells["QTY"].Value, row.Cells["TotalPrice"].Value);
                }
            }

            receipt += "------------------------------------------\n";
            receipt += "TOTAL:   $" + cashierOrder_totalprice.Text + "\n";
            receipt += "PAID:    $" + cashierOrder_amount.Text + "\n";
            receipt += "CHANGE:  $" + cashierOrder_change.Text + "\n";
            receipt += "------------------------------------------\n";

            MessageBox.Show(receipt, "Transaction Receipt", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}

        
