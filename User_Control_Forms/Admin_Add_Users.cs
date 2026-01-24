using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_Sys.Class_Files;



namespace Inventory_Management_Sys.User_Control_Forms
{
    public partial class Admin_Add_Users : UserControl
    {
        public Admin_Add_Users()
        {
            InitializeComponent();
            displayAll_Users_Data();
        }

        SqlConnection
           connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wasib\source\repos\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf;Integrated Security=True ");

        public void displayAll_Users_Data() 
        {
            Users_Data Users_D = new Users_Data();
            List<Users_Data> listData = Users_D.All_Users_Data();
            Add_User_Data_Grid_V.DataSource = listData;
        }
        private void Adduser_Add_Btn_Click(object sender, EventArgs e)
        {
            if (Adduser_Username.Text == "" || Adduser_Password.Text == "" ||
             Adduser_Role.SelectedIndex == -1 || Adduser_Status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CheckConnection())
                {
                    try
                    {
                        connect.Open();

                        string CheckUserName = "SELECT * FROM Users WHERE UserName = @User";

                        using (SqlCommand cmd = new SqlCommand(CheckUserName, connect))
                        {
                            cmd.Parameters.AddWithValue("@User", Adduser_Username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(Adduser_Username.Text.Trim() + " is already taken", "Error Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Users (UserName, Password, Role, Status, Date) " +
                                    "VALUES (@User, @Pass, @Role, @Status, @Date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@User", Adduser_Username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@Pass", Adduser_Password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@Role", Adduser_Role.SelectedItem.ToString());
                                    insertD.Parameters.AddWithValue("@Status", Adduser_Status.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@Date", today);

                                    insertD.ExecuteNonQuery();
                                    ClearFields();
                                    displayAll_Users_Data();

                                    MessageBox.Show("Added successfully", "Information Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                   
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

        public bool CheckConnection()
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

        public void ClearFields()
        {
            Adduser_Username.Text = "";
            Adduser_Password.Text = "";
            Adduser_Role.SelectedIndex = -1;
            Adduser_Status.SelectedIndex = -1;
        }

        private void Adduser_Clear_Btn_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void Adduser_Update_Btn_Click(object sender, EventArgs e)
        {
            if (Adduser_Username.Text == "" || Adduser_Password.Text == "" ||
            Adduser_Role.SelectedIndex == -1 || Adduser_Status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update User ID: " + getId + "?","Confirmation Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes )
                {
                    if (CheckConnection())
                    {
                        try
                        {
                            connect.Open();

                             string updateData = "UPDATE Users SET UserName = @User, " +
                                         "Password = @Pass, Role= @Role, Status = @Status WHERE Id = @Id";

                          using (SqlCommand updateD = new SqlCommand(updateData, connect))
                          {
                            updateD.Parameters.AddWithValue("@Id", getId);
                            updateD.Parameters.AddWithValue("@User", Adduser_Username.Text.Trim());
                            updateD.Parameters.AddWithValue("@Pass", Adduser_Password.Text.Trim());
                            updateD.Parameters.AddWithValue("@Role", Adduser_Role.SelectedItem.ToString());
                            updateD.Parameters.AddWithValue("@Status", Adduser_Status.SelectedItem.ToString());

                            updateD.ExecuteNonQuery();
                            ClearFields();
                            displayAll_Users_Data();

                                MessageBox.Show("Updated successfully", "Information Message",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                                      
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

        private int getId = 0;
        private void Add_User_Data_Grid_V_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = Add_User_Data_Grid_V.Rows[e.RowIndex];

                getId = (int)row.Cells[0].Value;
                string UserName = row.Cells[1].Value.ToString();
                string Password = row.Cells[2].Value.ToString();
                string Role = row.Cells[3].Value.ToString();
                string Status = row.Cells[4].Value.ToString();

                Adduser_Username.Text = UserName;
                Adduser_Password.Text = Password;
                Adduser_Role.SelectedItem = Role;
                Adduser_Status.Text = Status;

            }
        }

        private void Adduser_Remove_Btn_Click(object sender, EventArgs e)
        {
            if (Adduser_Username.Text == "" || Adduser_Password.Text == "" ||
            Adduser_Role.SelectedIndex == -1 || Adduser_Status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove User ID: " + getId + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CheckConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "DELETE FROM Users WHERE Id = @Id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@Id", getId);

                                updateD.ExecuteNonQuery();
                                ClearFields();
                                displayAll_Users_Data();

                                MessageBox.Show("Removed Successfully", "Information Message",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

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
