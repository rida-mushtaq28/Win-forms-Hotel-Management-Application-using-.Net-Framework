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
    public partial class UpdateHouseHelpAccountDetails : Form
    {
        public UpdateHouseHelpAccountDetails()
        {
            InitializeComponent();
            PersonDL.LoadUserDataFromList();
        }

        private void UpdateHouseHelpAccountDetails_Load(object sender, EventArgs e)
        {
            foreach (var househelp in PersonDL.PersonList)
            {
                if(househelp is HouseHelp)
                    cmbUserlist.Items.Add(househelp.GetUserName());
            }

        }

        private void btnupdateID_Click(object sender, EventArgs e)
        {

            BL.HouseHelp personObj =(HouseHelp) PersonDL.GetSpecificUserName(cmbUserlist.Text);
            if (personObj != null)
            { 
                    personObj.SetHouseHelpID((txtHousehelpID.Text));
                    PersonDL.WriteAllUserData();
                    MessageBox.Show("Updated Successfully");
                    OwnerMenu ownerMenu = new OwnerMenu();
                    this.Hide();
                    ownerMenu.Show();
             }
        }

        private void lblHousehelpID_Click(object sender, EventArgs e)
        {

        }

        private void txtHousehelpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
