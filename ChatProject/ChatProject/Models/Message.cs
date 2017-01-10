using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatProject.Models
{
    public class Message
    {
        public int MessageID { get; set; }

        public int RoomID { get; set; }

        public int UserID { get; set; }

        public int ToUserID { get; set; }

        public string Text { get; set; }

        public DateTime RecieveTime { get; set; }




    }
}