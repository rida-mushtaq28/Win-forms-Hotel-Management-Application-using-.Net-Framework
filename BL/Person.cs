using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplicationGUI.DL;

namespace BusinessApplicationGUI.BL
{
    public class Person
    {
        public string UserName;
        public string UserPassword;
        public Person(string Name, string Password)
        {
            SetUserName(Name);
            SetUserPassword(Password);
        }
        public Person()
        {

        }
        public string GetUserName()
        {
            return UserName;
        }
        public void SetUserName(string Name)
        {
            this.UserName = Name;
        }
        public string GetUserPassword()
        {
            return UserPassword;
        }
        public void SetUserPassword(string Password)
        {
            this.UserPassword = Password;
        }
        public virtual string ToString()
        {
            return UserName + "," + UserPassword + "," + "";
        }
    }
}
