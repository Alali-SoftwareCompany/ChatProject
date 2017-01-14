using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatProject.Models
{
    public class PrivateMessage
    {

        public int PrivateMessageID { get; set; }

        public int UserID { get; set; }

        public int ToUserID { get; set; }

        public int PrivateText { get; set; }



    }
}