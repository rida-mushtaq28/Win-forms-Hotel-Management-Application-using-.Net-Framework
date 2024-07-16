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
    public partial class UpdateServicesofHotel : Form
    {
        public UpdateServicesofHotel()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateServicesofHotel_Load(object sender, EventArgs e)
        {
            foreach(var  item in MenuItemDL.MenuItemList)
            {
                cmbList.Items.Add(item.GetRoomType());
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BL.MenuItem menuItem = MenuItemDL.GetRoomtype(cmbList.Text);
            if (menuItem != null)
            {
                menuItem.SetRoomPrice(float.Parse(txtUpdatePrice.Text));
                MenuItemDL.WriteAllRoomDetails();
                MessageBox.Show("Updated Successfully");
                OwnerMenu ownerMenu = new OwnerMenu();
                this.Hide();
                ownerMenu.Show();
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
