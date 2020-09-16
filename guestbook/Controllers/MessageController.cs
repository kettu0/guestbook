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
            messageList.Add(new Message("Geralt of Rivia", "geraltthewitcher@kaermohren.nov", "The best Dwarven spirit I've ever drunk. And trust me, I have some experience."));
            messageList.Add(new Message("Rowan", "thebraveadventurer@honeywood.au", "Great adventures await you here. But watch out for dead-eyed NPCs."));
            messageList.Add(new Message("Tyrion Lannister", "theImp@casterlyrock.west", "I drink and know things... especially here."));
            messageList.Add(new Message("Albus Dumbledore", "albuspercival@hogwarts.uk", "Best pumpkin cakes and firewhiskey... outside Hogwarts, of course."));
            messageList.Add(new Message("Legolas", "legolas@middle.earth", "I've taken the Hobbits here."));
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