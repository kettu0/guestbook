using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace guestbook.Models
{
    public class Message
    {
        public string Nickname { get; set; }
        public string eMail { get; set; }
        public string UserMessage { get; set; }

        public DateTime CurrentDate { get; set; }

        public Message(string nickname, string eMail, string userMessage)
        {
            this.Nickname = nickname;
            this.eMail = eMail;
            this.UserMessage = userMessage;
            this.CurrentDate = DateTime.Now;

        }

    }
}
