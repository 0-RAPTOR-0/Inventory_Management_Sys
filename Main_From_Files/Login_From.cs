using Inventory_Management_Sys.Main_From_Files;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Management_Sys
{
    public partial class Login_From : Form
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wasib\source\repos\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf;Integrated Security=True");
        public Login_From()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Label_Click(object sender, EventArgs e)
        {
            Register_Form RegForm = new Register_Form();
            RegForm.Show();
            this.Hide();
        }

        private void Login_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            Login_Password.PasswordChar = Login_ShowPass.Checked ? '\0' : '*';
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

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            if (CheckConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT (*) FROM Users WHERE UserName = @User AND Password = @Pass  AND Status = Status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@User", Login_Username.Text.Trim());
                        cmd.Parameters.AddWithValue("@Pass", Login_Password.Text.Trim());
                        cmd.Parameters.AddWithValue("@Status", "Active");

                        int rowCount = (int)cmd.ExecuteScalar();

                        if (rowCount > 0)
                        {
                            string selectRole = "SELECT Role FROM Users WHERE UserName = @User AND Password = @Pass";
                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@User", Login_Username.Text.Trim());
                                getRole.Parameters.AddWithValue("@Pass", Login_Password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                MessageBox.Show("Login Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                if (userRole == "Admin")
                                {
                                    Admin_Portal M_from = new Admin_Portal();
                                    M_from.Show();

                                    this.Hide();
                                }
                                else if (userRole == "Cashier")
                                {
                                    Cashier_Portal CM_from = new Cashier_Portal();
                                    CM_from.Show();
                                    this.Hide();
                                }


                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid Username/Password or Need Admin's approval",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void Login_From_Load(object sender, EventArgs e)
        {

        }
    }
}
