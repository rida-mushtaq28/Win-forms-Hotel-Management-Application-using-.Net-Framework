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
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {

        }

        private void detailsOfHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addHotelServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateHouseHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewHouseHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CustomerMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string menuStrip = e.ClickedItem.Text;
            if (menuStrip == AddOrderToolStripMenuItem.Text)
            {
                this.Hide();
                AddOrder order = new AddOrder();
                order.Show();
                order.Refresh();
            }
            else if (menuStrip == UpdateOrderToolStripMenuItem.Text)
            {
                this.Hide();
                UpdateOrder order = new UpdateOrder();
                order.Show();
                order.Refresh();

            }
            else if (menuStrip == deleteOrderToolStripMenuItem.Text)
            {
                this.Hide();
                DeleteOrder order = new DeleteOrder();
                order.Show();
                order.Refresh();
            }
            else if (menuStrip == viewOrderandbillsToolStripMenuItem.Text)
            {
                this.Hide();
                ViewOrderAndBills hoteldetails = new ViewOrderAndBills();
                hoteldetails.Show();
                hoteldetails.Refresh();
            }
            else if (menuStrip == GiveFeedbackToolStripMenuItem.Text)
            {
                this.Hide();
                GiveFeedBack hoteldetails = new GiveFeedBack();
                hoteldetails.Show();
                hoteldetails.Refresh();
            }
            else if (menuStrip == logoutToolStripMenuItem.Text)
            {
                this.Hide();
                SignIN signIN = new SignIN();
                signIN.Show();
                signIN.Refresh();
            }
        }
    }
}
