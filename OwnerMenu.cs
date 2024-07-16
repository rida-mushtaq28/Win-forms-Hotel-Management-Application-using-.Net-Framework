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
    public partial class OwnerMenu : Form
    {
        public OwnerMenu()
        {
            InitializeComponent();
            OwnerMenuStrip.ForeColor = Color.White;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string menuStrip = e.ClickedItem.Text;
           if(menuStrip==detailsOfHotelToolStripMenuItem.Text)
            {

                this.Hide();
                DetailsOfHotelForm hoteldetails = new DetailsOfHotelForm();
                hoteldetails.Show();
                hoteldetails.Refresh();
            }
           else if (menuStrip == addHotelServicesToolStripMenuItem.Text)
            {
                this.Hide();
                AddHoteldetails hoteldetails=new AddHoteldetails();
                hoteldetails.Show();
                hoteldetails.Refresh();

            }
           else if (menuStrip == deleteHotelServicesToolStripMenuItem.Text)
            {
                this.Hide();
                deleteHotelServices hoteldetails = new deleteHotelServices();
                hoteldetails.Show();
                hoteldetails.Refresh();
            }
           else if (menuStrip == updateHotelServicesToolStripMenuItem.Text)
            {
                this.Hide();
                UpdateServicesofHotel hoteldetails = new UpdateServicesofHotel();
                hoteldetails.Show();
                hoteldetails.Refresh();
            }
            else if (menuStrip == addHouseHelpToolStripMenuItem.Text)
            {
                this.Hide();
                AddHousehelp hoteldetails = new AddHousehelp();
                hoteldetails.Show();
                hoteldetails.Refresh();
            }
            else if (menuStrip == deleteHouseHelpToolStripMenuItem.Text)
            {
                this.Hide();
                DeleteHouseHelpAccount hoteldetails = new DeleteHouseHelpAccount();
                hoteldetails.Show();
                hoteldetails.Refresh();
            }
            else if (menuStrip == updateHouseHelpToolStripMenuItem.Text)
            {
                this.Hide();
                UpdateHouseHelpAccountDetails hoteldetails = new UpdateHouseHelpAccountDetails();
                hoteldetails.Show();
                hoteldetails.Refresh();
            }
            else if (menuStrip == viewHouseHelpToolStripMenuItem.Text)
            {
                this.Hide();
                AddHoteldetails hoteldetails = new AddHoteldetails();
                hoteldetails.Show();
                hoteldetails.Refresh();
            }
            else if (menuStrip == viewCustomerOrdersToolStripMenuItem.Text)
            {
                this.Hide();
                ViewOrderAndBills hoteldetails = new ViewOrderAndBills();
                hoteldetails.Show();
            }
            else if (menuStrip == viewFeedbackToolStripMenuItem.Text)
            {
                this.Hide();
                AddHoteldetails hoteldetails = new AddHoteldetails();
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OwnerMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
