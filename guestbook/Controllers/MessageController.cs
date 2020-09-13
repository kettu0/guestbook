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
        public List<Message> MessageModels { get; set; }

        public MessageController()
        {
            MessageModels = new List<Message>();
        }

        public List<Message> GetMessageList()
        {
            List<Message> MessageList = new List<Message>();

            MessageList.Add(new Message("Geralt of Rivia", "geraltthewitcher@kaermohren.nov", "Message 1", DateTime.Now));
            MessageList.Add(new Message("Rowan", "thebraveadventurer@honeywood.au", "Message 2", DateTime.Now));
            MessageList.Add(new Message("Albus Dumbledore", "albuspercival@hogwarts.uk", "Message 3", DateTime.Now));
            MessageList.Add(new Message("Tyrion Lannister", "theImp@casterlyrock.west", "Message 4", DateTime.Now));

            return MessageList;
        }

        [HttpGet]
        [Route("Message/Index")]
        public ActionResult Index()
        {
            List<Message> MessageList = GetMessageList();
            return View(MessageList);
        }

        public ActionResult SingleMessage()
        {
            var message = new Message("Anon", "anon@gmail.com", "Yo dawg", DateTime.Now);
            return View(message);
        }
    }
}