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
    public partial class UpdateOrder : Form
    {
        public UpdateOrder()
        {
            InitializeComponent();
            OrderDL.ReadOrderFromFile();
            MenuItemDL.ReadRoomDetailsFromFile();
        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {
            foreach (var o in OrderDL.OrderList)
            {
              cmbCustomerOrderlist.Items.Add(o.GetterTypeOfRoom());
            }
            foreach (var TypeOfRoomsInOrder in MenuItemDL.MenuItemList)
            {
               cmbTypeOfRoomsList.Items.Add(TypeOfRoomsInOrder.GetRoomType());
            }
        }

        private void cmbCustomerOrderlist_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            BL.MenuItem menu = MenuItemDL.GetRoomtype(cmbTypeOfRoomsList.Text);
            BL.Orders order = OrderDL.GetRoomtype(cmbCustomerOrderlist.Text);

            if (order != null )
            {
                order.SetTypeOfRoom(cmbTypeOfRoomsList.Text);
                order.SetNoofStay(int.Parse(txtTotalDays.Text));
                order.SetNoOfPerson(int.Parse(numericUpDownNoOfPerson.Value.ToString()));
                OrderDL.WriteAllOrder();
                MessageBox.Show("Updated Successfully");
                CustomerMenu customerMenu = new CustomerMenu();
                this.Hide();
                customerMenu.Show(this);
                customerMenu.Refresh();     
            }
        }

        private void dateTimePickerNoOfstaysTo_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = dateTimePickerForNoOfStaysFrom.Value.Date;
            DateTime end = dateTimePickerNoOfstaysTo.Value.Date;
            if (start > end)
            {
                MessageBox.Show("Invalid Date,Enter again");
                return;
            }
            txtTotalDays.Text = Convert.ToInt32(end.Subtract(start).Days).ToString();
        }
    }
}
