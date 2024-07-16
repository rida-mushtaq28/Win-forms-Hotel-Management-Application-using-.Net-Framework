using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplicationGUI.BL;
using System.IO;

namespace BusinessApplicationGUI.DL
{
    public class OrderDL
    {
        public static List<Orders> OrderList = new List<Orders>();
        public static void AddOrdersIntoList(Orders OrderObject)
        {
            OrderList.Add(OrderObject);
        }

        public static void WriteAllOrder()
        {
            OrderList.Clear();  
            string path = "Order.txt.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Orders OrderObject in OrderDL.OrderList)
            {
                file.WriteLine(OrderObject.GetNoOfPerson() + "," + OrderObject.GetNoOfStay() + "," + OrderObject.GetterTypeOfRoom());
            }
           
            file.Flush();
            file.Close();
        }

        public static void WriteOrderInFile(Orders OrderObject)
        {
            OrderList.Clear();
            string path = "Order.txt.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(OrderObject.GetNoOfPerson() + "," + OrderObject.GetNoOfStay() +","+ OrderObject.GetterTypeOfRoom());
            file.Flush();
            file.Close();
        }

        public static bool ReadOrderFromFile()
        {
            string path = "Order.txt.txt";
            StreamReader P = new StreamReader(path);
            string word;
            if (File.Exists(path))
            {
                while ((word = P.ReadLine()) != null)
                {
                    string[] splittedRecords = word.Split(',');
                    int NoOfPerson = int.Parse(splittedRecords[0]);
                    int NoOfStays = int.Parse(splittedRecords[1]);
                    string TypeOfRoom = splittedRecords[2];
                    Orders OrderObject = new Orders(NoOfPerson, NoOfStays, TypeOfRoom);
                    OrderDL.AddOrdersIntoList(OrderObject);
                }
                P.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Orders GetRoomtype(string name)
        {
            foreach (Orders item in OrderList)
            {
                if (name.ToLower() == item.GetterTypeOfRoom())
                {
                    return item;
                }
            }
            return null;
        }
        public static void DeleteOrder(Orders order)
        {
            OrderList.Remove(order);
        }
    }
}
