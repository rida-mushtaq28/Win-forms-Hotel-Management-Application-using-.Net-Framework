using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplicationGUI.BL;

namespace BusinessApplicationGUI.DL
{
    public class HouseHelpDL
    {
        public static List<HouseHelp> HouseHelpList = new List<HouseHelp>();
        public static void AddHouseHelpInfoInList(HouseHelp houseHelpObj)
        {
            HouseHelpList.Add(houseHelpObj);
        }
    }
}
