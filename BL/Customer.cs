using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplicationGUI.DL;

namespace BusinessApplicationGUI.BL
{
    public class Customer : Person
    {
        private string CustomerName;
        private string PhoneNumber;
        private List<Orders> BookedRoom = new List<Orders>();



        public Customer(string Username, string Password, string CustomerName, string PhoneNumber) : base(Username, Password)
        {
            SetCustomerName(CustomerName);
            SetCustomerPhoneNumber(PhoneNumber);
        }
        public List<Orders> BookedRooms { get => BookedRoom; set => BookedRoom = value; }
        public string GetCustomerName()
        {
            return CustomerName;
        }
        public void SetCustomerName(string CustomerName)
        {
            this.CustomerName = CustomerName;
        }
        public string GetCustomerPhoneNumber()
        {
            return PhoneNumber;
        }
        public void SetCustomerPhoneNumber(string PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }
        public override string ToString()
        {
            return GetUserName() + "," + GetUserPassword() + "," + "customer" + "," + GetCustomerName() + "," + GetCustomerPhoneNumber();
        }
        public static Orders getOrder(string username)
        {
            foreach (Orders i in OrderDL.OrderList)
            {
                if (i.customerName == username)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
