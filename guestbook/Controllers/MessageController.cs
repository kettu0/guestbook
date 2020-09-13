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
        // GET: Message
        public ActionResult SingleMessage()
        {
            var message = new Message() { Nickname = "Anon", eMail="anon@gmail.com", UserMessage="Yo dawg", CurrentDate=DateTime.Now};
            return View(message);
        }
    }
}