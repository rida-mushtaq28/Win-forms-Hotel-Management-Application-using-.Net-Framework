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
    public partial class AddHoteldetails : Form
    {
        public AddHoteldetails()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddHotelServicesIntoList_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTypeOfRoom.Text))
            {
                if (!string.IsNullOrEmpty(txtPriceofroom.Text))
                {
                    BL.MenuItem item = new BL.MenuItem(txtTypeOfRoom.Text, float.Parse(txtPriceofroom.Text));
                    MenuItemDL.AddMenuItemInMenuList(item);
                    MenuItemDL.WriteRoomDetailsInFile(item);
                    MessageBox.Show("Successfully added in the list", "Verification");
                    this.Hide();
                    OwnerMenu ownerMenu = new OwnerMenu();  
                    ownerMenu.Show();
                    ownerMenu.Refresh();
                }
                else
                {
                    MessageBox.Show("Invalid", "Invalid Info");
                }
            }
            else
            {
                MessageBox.Show("Invalid", "Invalid Info");
            }
        }

        private void AddHoteldetails_Load(object sender, EventArgs e)
        {

        }

        private void TypeofRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
