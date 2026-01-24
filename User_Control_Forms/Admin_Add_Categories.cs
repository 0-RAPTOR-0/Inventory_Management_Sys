using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory_Management_Sys.Class_Files;

namespace Inventory_Management_Sys.User_Control_Forms
{
    public partial class Admin_Add_Categories : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wasib\source\repos\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf;Integrated Security=True");
        public Admin_Add_Categories()
        {
            InitializeComponent();

            displayCategories_Data();
        }

        public void displayCategories_Data() 
        {
            Categories_Data Cat_D = new Categories_Data();
            List<Categories_Data> listData = Cat_D.All_Categories_Data();

            Add_Category_Data_Grid_V.DataSource = listData;
        }

        public bool checkConnection()
        {
            if(connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Add_Category_Add_Btn_Click(object sender, EventArgs e)
        {
            if(Add_Categories_category.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkCat = "SELECT * FROM Categories WHERE Category = @Category";

                        using (SqlCommand cmd = new SqlCommand(checkCat, connect))
                        {
                            cmd.Parameters.AddWithValue("@Category", Add_Categories_category.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Category: " + Add_Categories_category.Text.Trim() + " is already exixts",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Categories (Category, Date) VALUES (@Category, @Date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@Category", Add_Categories_category.Text.Trim());
                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@Date", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();

                                    displayCategories_Data();

                                    MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
            }
            
        }

        public void clearFields()
        {
            Add_Categories_category.Text = "";
        }

        private void Add_Category_Clear_Btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getId = 0;
        private void Add_Category_Data_Grid_V_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = Add_Category_Data_Grid_V.Rows[e.RowIndex];

                getId = (int)row.Cells[0].Value;

                Add_Categories_category.Text = row.Cells[1].Value.ToString();

            }
        }

        private void Add_Category_Update_Btn_Click(object sender, EventArgs e)
        {
            if (Add_Categories_category.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if(MessageBox.Show("Are you sure you want to update Category: " + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE Categories SET Category = @Category WHERE Id = @Id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@Category", Add_Categories_category.Text.Trim());
                                updateD.Parameters.AddWithValue("@Id", getId);

                                updateD.ExecuteNonQuery();
                                clearFields();

                                displayCategories_Data();

                                MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }

                    }
                }
            }
        }

        private void Add_Category_Remove_Btn_Click(object sender, EventArgs e)
        {
            if (Add_Categories_category.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove Category: " + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string removeData = "DELETE FROM Categories WHERE Id = @Id";

                            using (SqlCommand removeD = new SqlCommand(removeData, connect))
                            {
                                removeD.Parameters.AddWithValue("@Id", getId);

                                removeD.ExecuteNonQuery();
                                clearFields();

                                displayCategories_Data();

                                MessageBox.Show("Removed Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
