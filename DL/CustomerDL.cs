using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplicationGUI.BL;

namespace BusinessApplicationGUI.DL
{
    public class CustomerDL
    {
        private static List<Customer> CustomerList = new List<Customer>();
        public static void AddCustomerInfoInList(Customer CustomerObject)
        {
            CustomerList.Add(CustomerObject);
        }
        public static Customer GetCustomerUserName(string name)
        {
            foreach (Customer p in CustomerList)
            {
                if (name.ToLower() == p.GetUserName())
                {
                    return p;
                }
            }
            return null;
        }
    }
}
