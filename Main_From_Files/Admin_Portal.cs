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
using Inventory_Management_Sys.User_Control_Forms;


namespace Inventory_Management_Sys
{
    public partial class Admin_Portal : Form
    {
        public Admin_Portal()
        {
            InitializeComponent();
        }

        private void Dashboard_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login_From cmForm = new Login_From();
                cmForm.Show();
                this.Hide();

            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

