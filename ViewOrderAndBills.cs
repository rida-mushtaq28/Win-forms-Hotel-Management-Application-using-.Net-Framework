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
    public partial class ViewOrderAndBills : Form
    {
        public ViewOrderAndBills()
        {
            InitializeComponent();
            OrderDL.ReadOrderFromFile();
            MenuItemDL.ReadRoomDetailsFromFile();
        }

        private void ViewOrderAndBills_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.Add("RoomType", typeof(String));
            data.Columns.Add("No Of Persons", typeof(int));
            data.Columns.Add("No Of Stays", typeof(int));
            foreach (BL.Orders order in OrderDL.OrderList)
            {
                data.Rows.Add(order.GetterTypeOfRoom(), order.NoOfPerson,order.NoOfStays);
            }
            grdViewOrder.DataSource = null;
            grdViewOrder.DataSource = data;
            grdViewOrder.Refresh();

            foreach (BL.Orders order in OrderDL.OrderList)
            {
                foreach (BL.MenuItem menuItem in MenuItemDL.MenuItemList)
                {
                    if (order.GetterTypeOfRoom() == menuItem.GetRoomType())
                    {
                      string bill= (order.NoOfStays*menuItem.RoomPrice).ToString();
                      lblTotalBill.Text =bill;   
                      
                    }
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.Show(this);
            customerMenu.Refresh();
        }
    }
}
