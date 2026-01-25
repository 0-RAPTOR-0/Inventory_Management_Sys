using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_Sys.Class_Files;

namespace Inventory_Management_Sys.User_Control_Forms
{
    public partial class Customer_Form: UserControl
    {
        public Customer_Form()
        {
            InitializeComponent();
            displayAllCustomer();
        }

        public void displayAllCustomer()
        {
            CustomersData cust = new CustomersData();
            List<CustomersData> listCustomers = cust.AllCustomers();
            dataGridView1.Rows.Clear();
        }
    }
}
