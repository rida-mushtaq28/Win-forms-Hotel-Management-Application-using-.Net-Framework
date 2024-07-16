using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplicationGUI.DL;

namespace BusinessApplicationGUI.BL
{
    public class Orders
    {
        public int NoOfRooms;
        public List<string> TypeOfRoom = new List<string>();
        private string typeOfRooms;
        public int NoOfStays;
        public int NoOfPerson;
        public string FeedBack;
        public string customerName;

        public Orders(int NoOfRooms, int NoOfStays, int NoOfPerson, string customerName)
        {
            this.NoOfRooms = NoOfRooms;
            this.NoOfStays = NoOfStays;
            this.NoOfPerson = NoOfPerson;
            this.customerName = customerName;
            this.TypeOfRoom = new List<string>();
        }
        public Orders(int NoOfStays, int NoOfPerson,string typeofrooms)
        {
            this.NoOfStays = NoOfStays;
            this.NoOfPerson = NoOfPerson;
            this.typeOfRooms = typeofrooms;
        }
        public Orders()
        {

        }
        public Orders(string FeedBack)
        {
            this.FeedBack = FeedBack;
        }
        public int GetNoOfRooms()
        {
            return NoOfRooms;
        }
        public void SetNoOfRooms(int NoOfRooms)
        {
            this.NoOfRooms = NoOfRooms;
        }
        public int GetNoOfStay()
        {
            return NoOfStays;
        }
        public void SetNoofStay(int NoOfStays)
        {
            this.NoOfStays = NoOfStays;
        }
        public List<string> GetTypeOfRoom()
        {
            return TypeOfRoom;
        }
        public void SetTypeOfRoom(string TypeOfRoom)
        {
            this.typeOfRooms = TypeOfRoom;
        }
        public string GetterTypeOfRoom()
        {
            return typeOfRooms;
        }
        public void SetTypeOfRoom(List<string> TypeOfRoom)
        {
            this.TypeOfRoom = TypeOfRoom;
        }
        public int GetNoOfPerson()
        {
            return NoOfPerson;
        }
        public void SetNoOfPerson(int NoOfPerson)
        {
            this.NoOfPerson = NoOfPerson;
        }
        public string GetFeedBack()
        {
            return FeedBack;
        }
        public void SetFeedBack(string FeedBack)
        {
            this.FeedBack = FeedBack;
        }
        public static bool validOrder(Orders orderObject, List<MenuItem> MenuItemList)
        {
            bool flag = false;
            foreach (MenuItem m in MenuItemList)
            {
                foreach (string i in orderObject.TypeOfRoom)
                {
                    if (m.RoomType == i)
                    {
                        return true;
                    }
                }
            }
            return flag;
        }
    }
}
