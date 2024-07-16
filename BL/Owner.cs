using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplicationGUI.DL;

namespace BusinessApplicationGUI.BL
{
    public class Owner : Person
    {
        private string OwnerName;
        public Owner(string name, string password, string OwnerName) : base(name, password)
        {
            SetOwnerName(OwnerName);
        }

        public string GetOwnerName()
        {
            return OwnerName;
        }
        public void SetOwnerName(string OwnerName)
        {
            this.OwnerName = OwnerName;
        }
        public override string ToString()
        {
            return GetUserName() + "," + GetUserPassword() + "," + "owner" + "," + GetOwnerName();
        }
        public  float CalculateBill(Orders OrderObject)
        {
            float bill = 0;
            if (OrderObject == null)
            {
                return bill;
            }

            foreach (string room in OrderObject.TypeOfRoom)
            {
                foreach (MenuItem m in MenuItemDL.MenuItemList)
                {
                    if (m.RoomType == room)
                    {
                        bill = bill + (m.RoomPrice * OrderObject.NoOfStays);
                    }
                }
            }
            return bill;
        }
    }
}
