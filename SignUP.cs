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
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUserName.Text))
            {
                if (!String.IsNullOrEmpty(txtPassword.Text))
                {
                    if (!String.IsNullOrEmpty(txtUserRole.Text) || txtUserRole.Text == "househelp")
                    {
                        Person person = new Person(txtUserName.Text.ToLower(), txtPassword.Text.ToLower());
                        PersonDL.AddSignedUpPerson(person);
                        PersonDL.StoreUserData(person);
                        MessageBox.Show("Signed UP Successfully", "Verification");
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

        private void lblAlreadyAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIN signIN = new SignIN();
            signIN.Show();
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }
    }
}
