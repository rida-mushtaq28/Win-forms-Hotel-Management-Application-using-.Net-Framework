using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplicationGUI.DL;

namespace BusinessApplicationGUI.BL
{
    public class HouseHelp : Person
    {
        public string HouseHelpName;
        public string HouseHelpID;
        public HouseHelp(string UserName, string UserPassword, string HouseHelpName, string HouseHelpID) : base(UserName, UserPassword)
        {
            SetHouseHelpName(HouseHelpName);
            SetHouseHelpID(HouseHelpID);
        }
        public HouseHelp()
        {
            SetHouseHelpName(HouseHelpName);
            SetHouseHelpID(HouseHelpID);
        }
        public string GetHouseHelpName()
        {
            return HouseHelpName;
        }
        public void SetHouseHelpName(string HouseHelpName)
        {
            this.HouseHelpName = HouseHelpName;
        }
        public string GetHouseHelpID()
        {
            return HouseHelpID;
        }
        public void SetHouseHelpID(string HouseHelpID)
        {
            this.HouseHelpID = HouseHelpID;
        }
        public override string ToString()
        {
            return GetUserName() + "," + GetUserPassword() + "," + "househelp" + "," + GetHouseHelpName() + "," + GetHouseHelpID();
        }
        public static void HouseHelpInterface()
        {
            Console.WriteLine("hyyyyyyy ma househelp hon");
        }
    }
}
