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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
            MenuItemDL.ReadRoomDetailsFromFile();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

            foreach (var item in MenuItemDL.MenuItemList)
            {
                cmbTypeOfRooms.Items.Add(item.GetRoomType());
            }

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Customer CustomerObject= CustomerDL.GetCustomerUserName(Program.StoredUserName);
            BL.MenuItem menuItem = MenuItemDL.GetRoomtype(cmbTypeOfRooms.Text);
            BL.Orders Order = new BL.Orders(int.Parse(numericUpDownNoOfPerson.Value.ToString()),int.Parse(txtTotalDays.Text), cmbTypeOfRooms.Text);
            if (Order != null)
            {
                if (cmbTypeOfRooms.Text != null)
                {
                    if (txtTotalDays.Text != null)
                    {
                        CustomerObject.BookedRooms.Add(Order);
                        OrderDL.WriteOrderInFile(Order);
                        MessageBox.Show("Successfully Ordered ", "Verification");
                        CustomerMenu customerMenu = new CustomerMenu();
                        this.Hide();
                        customerMenu.Show();
                       
                    }
                    else
                    {
                        MessageBox.Show("Not  valid");
                    }
                }
                else
                {
                    MessageBox.Show("Not  valid");
                }
            }
            else
            {
                MessageBox.Show("Not  valid");
            }
        }

        private void lblNoOfStays_Click(object sender, EventArgs e)
        {

        }

        private class Dim
        {
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {

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

        private void lblTypeOfRoom_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
