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
    public partial class DeleteHouseHelpAccount : Form
    {
        public DeleteHouseHelpAccount()
        {
            InitializeComponent();
            PersonDL.LoadUserDataFromList();
        }

        private void DeleteHouseHelpAccount_Load(object sender, EventArgs e)
        {
            foreach (BL.Person p in PersonDL.PersonList)
            {
                if(p is HouseHelp)
                    cmbUserList.Items.Add(p.GetUserName());
            }
        }

        private void btnDeleteAcoount_Click(object sender, EventArgs e)
        {
            PersonDL.DeleteHousehelpAccount(PersonDL.GetSpecificUserName(cmbUserList.Text));
            PersonDL.WriteAllUserData();
            MessageBox.Show("Deleted Successfully");
            OwnerMenu ownerMenu = new OwnerMenu();
            this.Hide();
            ownerMenu.Show();
        }
    }
}
