using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplicationGUI.DL;

namespace BusinessApplicationGUI.BL
{
    public class MenuItem
    {
        public string RoomType;
        public float RoomPrice;
        public MenuItem(string RoomType, float RoomPrice)
        {
            this.RoomType = RoomType;
            this.RoomPrice = RoomPrice;
        }
        public MenuItem()
        {

        }
        public string GetRoomType()
        {
            return RoomType;
        }
        public void SetRoomType(string RoomType)
        {
            this.RoomType = RoomType;
        }
        public float GetRoomPrice()
        {
            return RoomPrice;
        }
        public void SetRoomPrice(float RoomPrice)
        {
            this.RoomPrice = RoomPrice;
        }
    }
}
