using BusinessApplicationGUI.BL;
using BusinessApplicationGUI.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplicationGUI
{
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();
            OrderDL.ReadOrderFromFile();
        }

        private void DeleteOrder_Load(object sender, EventArgs e)
        {
            foreach (var customer in PersonDL.PersonList)
            {
                if (customer is Customer)
                {
                    cmbCustomerList.Items.Add(customer.GetUserName());
                }

            }
            foreach (var order in OrderDL.OrderList)
            {    
              cmbOrderList.Items.Add(order.GetterTypeOfRoom());
            }
        }

        private void btnDeleteServices_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbCustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerList.Text == Program.StoredUserName)
            {
                cmbCustomerList.Text = Program.StoredUserName;
            }
            else
            {
                MessageBox.Show("Select Your own Username");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.Customer personObj = (Customer)PersonDL.GetSpecificUserName(cmbCustomerList.Text);
            OrderDL.DeleteOrder(OrderDL.GetRoomtype(cmbOrderList.Text));
            OrderDL.WriteAllOrder();
            MessageBox.Show("Deleted Successfully");
            this.Hide();
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.Show(this);
            customerMenu.Refresh();

        }
    }
}
