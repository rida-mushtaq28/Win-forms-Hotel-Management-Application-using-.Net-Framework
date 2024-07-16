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
    public partial class AddHousehelp : Form
    {
        public AddHousehelp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUserName.Text))
            {
                if (!String.IsNullOrEmpty(txtUserPassword.Text))
                {
                    if (!String.IsNullOrEmpty(txtUserRole.Text) || txtUserRole.Text=="househelp")
                    {
                        Person person = new Person(txtUserName.Text.ToLower(), txtUserPassword.Text.ToLower());
                        PersonDL.AddSignedUpPerson(person);
                        PersonDL.StoreUserData(person);
                        MessageBox.Show("Signed UP Successfully", "Verification");
                        this.Hide();
                        OwnerMenu ownerMenu = new OwnerMenu();
                        ownerMenu.Show();
                        ownerMenu.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Enter Role ", "Invalid Info");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Password ", "Invalid Info");
                }
            }
            else
            {
                MessageBox.Show("Enter Name ", "Invalid Info");
            }
        }

        private void AddHousehelp_Load(object sender, EventArgs e)
        {

        }
    }
}
