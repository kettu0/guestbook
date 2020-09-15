using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using guestbook.Models;

namespace guestbook.Controllers
{
    public class MessageController : Controller
    {
        public static List<Message> MessageModels;


        public List<Message> GetMessageList()
        {
            var messageList = new List<Message>();
            messageList.Add(new Message("Geralt of Rivia", "geraltthewitcher@kaermohren.nov", "Message 1"));
            messageList.Add(new Message("Rowan", "thebraveadventurer@honeywood.au", "Message 2"));
            messageList.Add(new Message("Albus Dumbledore", "albuspercival@hogwarts.uk", "Message 3"));
            messageList.Add(new Message("Tyrion Lannister", "theImp@casterlyrock.west", "Message 4"));

            return messageList;
        }

        [HttpGet]
        [Route("Message/Index")]
        public ActionResult Index()
        {
            MessageModels = GetMessageList();
            return View(MessageModels);
        }

        [HttpPost]
        [Route("Message/Index")]
        public ActionResult Index(string Nickname, string eMail, string UserMessage)
        {
            MessageModels.Add(new Message(Nickname, eMail, UserMessage));
            return View(MessageModels);
        }
    }
}