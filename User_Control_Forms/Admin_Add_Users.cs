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


namespace Inventory_Management_Sys.User_Control_Forms
{
    public partial class Admin_Add_Users : UserControl
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\AIUB\New folder\C#\Lab\Project\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf"";Integrated Security=True;Connect Timeout=30 ");
        public Admin_Add_Users()
        {
            InitializeComponent();
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

                                    MessageBox.Show("Added successfully", "Information Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Adduser_Username.Clear();
                                    Adduser_Password.Clear();
                                    Adduser_Role.SelectedIndex = -1;
                                    Adduser_Status.SelectedIndex = -1;
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
    }
}
