using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Inventory_Management_Sys.User_Control_Forms
{
    public partial class Cashier_Order_Form: UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wasib\source\repos\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf;Integrated Security=True");

        public Cashier_Order_Form()
        {
            InitializeComponent();

            displayAllAvailableProducts 
                ();
           
        }

        public void displayAllAvailableProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.AllAvailableProducts();

            DataGridView1.DataSource = listData;    
        }

        public bool checkconnection()
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

        public bool displayCategories()
        {
            if (checkconnection())
            {
                try
                {
                    connect.Open();

                    string seletctData = "SELECT * FROM Categories ";

                    using (SqlCommand cmd = new SqlCommand(seletctData, connect))
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





            string selectedValue = cashierOrder_Catagroy.SelectedItem as string;

            if (selectedValue != null)
            {
                if (checkconnection())
                {
                    try
                    {
                        connect.Open();
                        string seletctData = $"SELECT * FROM prod_id = '{selectedValue}' AND Status = @status ";

                        using (SqlCommand cmd = new SqlCommand(selectData, (SqlConnection)connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                cashierOrder_Products.Items.Clear();
                                while (reader.Read())
                                {
                                    string item = reader["prod_id"].ToString();
                                    cashierOrder_prodID.Items.Add(item);
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
                    {
                        try
                        {
                            connect.Open();
                            string selectData = $"SELECT * FROM products WHERE prod_id = '{selectedValue}' AND status = @status";
                            using (SqlCommand cmd = new SqlCommand(selectData, connect))
                            {
                                cmd.Parameters.AddWithValue("@status", "Available");
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string prodName = reader["prod_name"].ToString(); float prodPrice = Convert.ToSingle(reader["price"]);
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
        }
    }
}
