using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management_Sys
{
    public partial class Login_From : Form
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\AIUB\New folder\C#\Lab\Project\Inventory_Management_Sys\I_M_S_Database\I_M_S_DB.mdf"";Integrated Security=True;Connect Timeout=30 ");
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
            Login_Password.PasswordChar = Login_ShowPass.Checked ? '\0' : '*' ;
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
                    string selectData = "SELECT * FROM Users WHERE UserName = @Users AND Password = @Pass";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@Users", Login_Username.Text.Trim());
                        cmd.Parameters.AddWithValue("@Pass", Login_Password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Main_Form M_from = new Main_Form ();
                            M_from.Show();

                            this.Hide();

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
