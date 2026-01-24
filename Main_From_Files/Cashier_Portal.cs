using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_Management_Sys.Main_From_Files
{
    public partial class Cashier_Portal : Form
    {
        public Cashier_Portal()
        {
            InitializeComponent();
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

   }
}
