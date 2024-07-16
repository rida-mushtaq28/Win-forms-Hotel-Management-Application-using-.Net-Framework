using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessApplicationGUI.DL;
using BusinessApplicationGUI.BL;

namespace BusinessApplicationGUI
{
    public partial class SignIN : Form
    {
        public SignIN()
        {

            InitializeComponent();
            PersonDL.LoadUserDataFromList();
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (!String.IsNullOrEmpty(txtPassword.Text))
            {
                if (!String.IsNullOrEmpty(txtUsername.Text))
                {
                    
                    foreach(Person person in PersonDL.PersonList)
                    {
                        if (person is Owner)
                        {
                            if (person.UserName == txtUsername.Text && person.UserPassword == txtPassword.Text)
                            {
                                check = true;
                                person.UserName = Program.StoredUserName;
                                this.Hide();
                                OwnerMenu owner = new OwnerMenu();
                                owner.Show();
                            }
                        }
                        if (person is Customer)
                        {
                            if (person.UserName == txtUsername.Text && person.UserPassword == txtPassword.Text)
                            {
                                check = true;
                                Program.StoredUserName= person.UserName;
                                this.Hide();
                                CustomerMenu customer = new CustomerMenu();
                                customer.Show();
                            }
                        }
                        if (person is HouseHelp)
                        {
                            if (person.UserName == txtUsername.Text && person.UserPassword == txtPassword.Text)
                            {
                                check = true;
                                person.UserName = Program.StoredUserName;
                                this.Hide();
                                HouseHelpMenu househelp = new HouseHelpMenu();
                                househelp.Show();
                            }
                        }

                    }
                    if (!check)
                        MessageBox.Show("Invalid User");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCreateanAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUP signUP = new SignUP();
            signUP.Show();
        }

        private void SignIN_Load(object sender, EventArgs e)
        {

        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {

        }
    }
}
