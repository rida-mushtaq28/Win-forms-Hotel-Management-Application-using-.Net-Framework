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
    public partial class GiveFeedBack : Form
    {
        public GiveFeedBack()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Orders order = new Orders(txtFeedback.Text);
            OrderDL.AddOrdersIntoList(order);
            MessageBox.Show("Submitted Successfully!");
            this.Hide();
            CustomerMenu customer = new CustomerMenu();
            customer.Show(this);
            customer.Refresh();
        }

        private void GiveFeedBack_Load(object sender, EventArgs e)
        {

        }
    }
}
