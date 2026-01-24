using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_Sys
{
    public partial class Register_Form : Form
    {

        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\AIUB\New folder\C#\Lab\Project\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf"";Integrated Security=True;Connect Timeout=30 ");
        public Register_Form()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Label_Click(object sender, EventArgs e)
        {
            Login_From LoginForm = new Login_From();
            LoginForm.Show();
            this.Hide();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (Register_Username.Text == "" || Register_Password.Text == "" || Register_Xpassword.Text == "")
            {
                MessageBox.Show("Please fill all empty fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            cmd.Parameters.AddWithValue("@User", Register_Username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(Register_Username.Text.Trim() +
                                    "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (Register_Password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid Password, at least 8 Charecters", "Error Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (Register_Password.Text.Trim() != Register_Xpassword.Text.Trim())
                            {
                                MessageBox.Show("Password does not match", "Error Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Users (UserName, Password, Role, Status, Date)" +
                                " VALUES (@User, @Pass, @Role, @Status, @Date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@User", Register_Username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@Pass", Register_Password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@Role", "Cashier");
                                    insertD.Parameters.AddWithValue("@Status", "Approval");

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@Date", today);

                                    insertD.ExecuteNonQuery();

                                    MessageBox.Show("Account Created Successfully", "Information Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Login_From LoginForm = new Login_From();
                                    LoginForm.Show();

                                    this.Hide();
                                }
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed" + ex, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void Register_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            Register_Password.PasswordChar = Register_ShowPass.Checked ? '\0' : '*';
            Register_Xpassword.PasswordChar = Register_ShowPass.Checked ? '\0' : '*';
        }

        private void Register_Form_Load(object sender, EventArgs e)
        {

             


        }
    }
}
