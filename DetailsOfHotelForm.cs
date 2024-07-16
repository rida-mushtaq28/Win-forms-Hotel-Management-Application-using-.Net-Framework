using BusinessApplicationGUI.BL;
using BusinessApplicationGUI.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplicationGUI
{
    public partial class DetailsOfHotelForm : Form
    {
        public DetailsOfHotelForm()
        {
            InitializeComponent();
            MenuItemDL.ReadRoomDetailsFromFile();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DetailsOfHotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DetailsOfHotelForm_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.Add("RoomType", typeof(String));
            data.Columns.Add("RoomPrice", typeof(float));

            foreach (BL.MenuItem item in MenuItemDL.MenuItemList)
            {
                data.Rows.Add(item.RoomType, item.RoomPrice);
            }
            DetailsOfHotel.DataSource = null;
            DetailsOfHotel.DataSource = data;
            DetailsOfHotel.Refresh();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            OwnerMenu ownerMenu = new OwnerMenu();
            ownerMenu.Show();
            ownerMenu.Refresh();
        }
    }
}
