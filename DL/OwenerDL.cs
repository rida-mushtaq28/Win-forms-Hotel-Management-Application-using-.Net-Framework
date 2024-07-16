using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplicationGUI.BL;
using System.IO;

namespace BusinessApplicationGUI.DL
{
    public class OwenerDL
    {
        private static List<Owner> OwnerList = new List<Owner>();
        public static void AddOwnerInfoInList(Owner OwnerObject)
        {
            OwnerList.Add(OwnerObject);
        }
    }
}
