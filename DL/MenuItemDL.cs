using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BusinessApplicationGUI.BL;

namespace BusinessApplicationGUI.DL
{
    public class MenuItemDL
    {
        public static List<MenuItem> MenuItemList = new List<MenuItem>();
        public static void AddMenuItemInMenuList(MenuItem MenuItemObject)
        {
            MenuItemList.Add(MenuItemObject);
        }
        public static void WriteAllRoomDetails()
        {
            string path = "RoomDetails.txt.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (MenuItem MenuItemObject in MenuItemDL.MenuItemList)
            {
                file.WriteLine(MenuItemObject.GetRoomType() + "," + MenuItemObject.GetRoomPrice());
            }
            file.Flush();
            file.Close();
        }
        public static void WriteRoomDetailsInFile(MenuItem MenuItemObject)
        {
            string path = "RoomDetails.txt.txt";
            StreamWriter file = new StreamWriter(path,true);
            file.WriteLine(MenuItemObject.GetRoomType() + "," + MenuItemObject.GetRoomPrice());
            file.Flush();
            file.Close();
        }
        public static bool ReadRoomDetailsFromFile()
        {
            string path = "RoomDetails.txt.txt";
            StreamReader P = new StreamReader(path);
            string word;
            if (File.Exists(path))
            {
                while ((word = P.ReadLine()) != null)
                {
                    string[] splittedRecords = word.Split(',');
                    string RoomType = splittedRecords[0];
                    float password = float.Parse(splittedRecords[1]);
                    MenuItem data = new MenuItem(RoomType, password);
                    MenuItemDL.AddMenuItemInMenuList(data);
                }
                P.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static MenuItem GetRoomtype(string name)
        {
            foreach (MenuItem item in MenuItemDL.MenuItemList)
            {
                if (name.ToLower() == item.GetRoomType())
                {
                    return item;
                }
            }
            return null;
        }
        public static void DeleteMenuItem(MenuItem menuItem)
        {
         MenuItemList.Remove(menuItem);          
        }
    }
}
