using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Inventory_Management_Sys.Class_Files;


namespace Inventory_Management_Sys.User_Control_Forms
{
    public partial class Admin_Add_Products : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wasib\source\repos\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf;Integrated Security=True");
        public Admin_Add_Products()
        {
            InitializeComponent();

            displayCategories();
            displayAll_Products();
        }

        public void displayAll_Products()
        {
            Products_Data Pro_D = new Products_Data();
            List<Products_Data> listData = Pro_D.All_Products();

            Add_Pro_Data_Grid_V.DataSource = listData;
        }
        public bool EmptyFields()
        {
            if (Add_Product_ID.Text == "" || Add_Product_Name.Text == "" || Add_Product_Category.SelectedIndex == -1 ||
                Add_Product_Price.Text == "" || Add_Product_Stock.Text == "" || Add_Product_Status.SelectedIndex == -1 ||
                Add_Product_Image_V.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayCategories()
        {
            if (checkConnection()) { connect.Close(); }

            try
            {
                connect.Open();
                string selectData = "SELECT * FROM Categories";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    Add_Product_Category.Items.Clear();
                    while (reader.Read())
                    {
                        Add_Product_Category.Items.Add(reader["Category"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        private void Add_Product_Add_Btn_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                MessageBox.Show("Empty fields detected.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM Products WHERE Product_ID = @Pro_ID";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@Pro_ID", Add_Product_ID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Product ID: " + Add_Product_ID.Text.Trim() + "is existing already",
                                    "Error Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                                string relativePath = Path.Combine("Product_Images", Add_Product_ID.Text.Trim() + ".jpg");

                                string path = Path.Combine(baseDirectory, relativePath);
                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(Add_Product_Image_V.ImageLocation, path, true);

                                string insertData = "INSERT INTO Products" + "(Product_ID, Product_Name, Category, Price, Stock, Status, Image_Path, Date_Insert)" +
                                    "VALUES (@Pro_ID, @Pro_Name, @Pro_Category, @Pro_Price, @Pro_Stock, @Pro_Status, @Pro_Image_Path, @Pro_Date_Insert)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@Pro_ID", Add_Product_ID.Text.Trim());
                                    insertD.Parameters.AddWithValue("@Pro_Name", Add_Product_Name.Text.Trim());
                                    insertD.Parameters.AddWithValue("@Pro_Category", Add_Product_Category.SelectedItem);
                                    insertD.Parameters.AddWithValue("@Pro_Price", Add_Product_Price.Text.Trim());
                                    insertD.Parameters.AddWithValue("@Pro_Stock", Add_Product_Stock.Text.Trim());
                                    insertD.Parameters.AddWithValue("@Pro_Status", Add_Product_Status.SelectedItem);
                                    insertD.Parameters.AddWithValue("@Pro_Image_Path", path);

                                    DateTime today = DateTime.Today;

                                    insertD.Parameters.AddWithValue("@Pro_Date_Insert", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayAll_Products();

                                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }


        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Add_Product_Import_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "Image Files(*.jpg; *.png)|*.jpg; *.png";

                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    Add_Product_Image_V.ImageLocation = imagePath;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearFields()
        {
            Add_Product_ID.Text = "";
            Add_Product_Name.Text = "";
            Add_Product_Category.SelectedIndex = -1;
            Add_Product_Price.Text = "";
            Add_Product_Stock.Text = "";
            Add_Product_Status.SelectedIndex = -1;
            Add_Product_Image_V.Image = null;
        }
        private void Add_Product_Clear_Btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getId = 0;
        private void Add_Pro_Data_Grid_V_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = Add_Pro_Data_Grid_V.Rows[e.RowIndex];

                getId = (int)row.Cells[0].Value;

                Add_Product_ID.Text = row.Cells[1].Value.ToString();
                Add_Product_Name.Text = row.Cells[2].Value.ToString();
                Add_Product_Category.Text = row.Cells[3].Value.ToString();
                Add_Product_Price.Text = row.Cells[4].Value.ToString();
                Add_Product_Stock.Text = row.Cells[5].Value.ToString();
                Add_Product_Status.Text = row.Cells[6].Value.ToString();

                string imagePath = row.Cells[8].Value.ToString();

                try
                {
                    if (imagePath != null)
                    {
                        Add_Product_Image_V.Image = Image.FromFile(imagePath);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Image: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Add_Product_Remove_Btn_Click(object sender, EventArgs e)
        {
            if (getId == 0)
            {
                MessageBox.Show("Please select an item from the table first.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to remove product ID: " + Add_Product_ID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string removeData = "DELETE FROM Products WHERE Id = @Id";

                        using (SqlCommand removeD = new SqlCommand(removeData, connect))
                        {
                            removeD.Parameters.AddWithValue("@Id", getId);
                            removeD.ExecuteNonQuery();

                            displayAll_Products();
                            clearFields();
                            getId = 0;

                            MessageBox.Show("Removed Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Remove failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void Add_Product_Update_Btn_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                MessageBox.Show("Empty fields detected.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update product: " + Add_Product_ID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                            string relativePath = Path.Combine("Product_Images", Add_Product_ID.Text.Trim() + ".jpg");
                            string path = Path.Combine(baseDirectory, relativePath);

                            if (Add_Product_Image_V.ImageLocation != null)
                            {
                                if (Add_Product_Image_V.Image != null)
                                {
                                    Add_Product_Image_V.Image.Dispose();
                                    Add_Product_Image_V.Image = null;
                                }

                                GC.Collect();
                                GC.WaitForPendingFinalizers();

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(Add_Product_Image_V.ImageLocation, path, true);
                            }

                            string updateData = "UPDATE Products SET Product_ID = @Pro_ID, Product_Name = @Pro_Name, " +
                                                "Category = @Pro_Category, Price = @Pro_Price, Stock = @Pro_Stock, " +
                                                "Status = @Pro_Status, Image_Path = @Pro_Image_Path, Date_Insert = @Pro_Date " +
                                                "WHERE Id = @Id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@Pro_ID", Add_Product_ID.Text.Trim());
                                updateD.Parameters.AddWithValue("@Pro_Name", Add_Product_Name.Text.Trim());
                                updateD.Parameters.AddWithValue("@Pro_Category", Add_Product_Category.SelectedItem);
                                updateD.Parameters.AddWithValue("@Pro_Price", Add_Product_Price.Text.Trim());
                                updateD.Parameters.AddWithValue("@Pro_Stock", Add_Product_Stock.Text.Trim());
                                updateD.Parameters.AddWithValue("@Pro_Status", Add_Product_Status.SelectedItem);
                                updateD.Parameters.AddWithValue("@Pro_Image_Path", path);
                                updateD.Parameters.AddWithValue("@Pro_Date", DateTime.Today);
                                updateD.Parameters.AddWithValue("@Id", getId);

                                updateD.ExecuteNonQuery();

                                displayAll_Products();
                                clearFields();

                                MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Update failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


