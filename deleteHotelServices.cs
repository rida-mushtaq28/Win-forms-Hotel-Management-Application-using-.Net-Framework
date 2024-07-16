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
    public partial class deleteHotelServices : Form
    {
        public deleteHotelServices()
        {
            InitializeComponent();
        }

        private void cmbServicesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteHotelServices_Load(object sender, EventArgs e)
        {
            foreach (BL.MenuItem items in MenuItemDL.MenuItemList)
            {
                cmbServicesList.Items.Add(items.GetRoomType());
            }
        }

        private void btnDeleteServices_Click(object sender, EventArgs e)
        {
            MenuItemDL.DeleteMenuItem(MenuItemDL.GetRoomtype(cmbServicesList.Text));
            MenuItemDL.WriteAllRoomDetails();
            MessageBox.Show("Deleted Successfully");
            OwnerMenu ownerMenu = new OwnerMenu();
            this.Hide();
            ownerMenu.Show();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
