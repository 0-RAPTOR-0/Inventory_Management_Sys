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
        private object connect;
        private string selectData;

        public Cashier_Order_Form()
        {
            InitializeComponent();
        }

        public bool checkconnection()
        {
            if (connect.state == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
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
