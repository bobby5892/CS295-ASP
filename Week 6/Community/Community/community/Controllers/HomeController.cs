using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using community.Models;
using System.Web;
using community.Repositories;
namespace community.Controllers
{
    public class HomeController : Controller
    {
        // Once we have auth we can ditch this.
        User CurrentUser = new User() { Name="Ted",EmailAddress="example@example.com"};
        public IContactRepository contactsRepo;
        public IMessageRepository messagesRepo;
        public HomeController(IContactRepository contactRepo, IMessageRepository messageRepo)
        {
            contactsRepo = contactRepo;
            messagesRepo = messageRepo;
        }
        public IActionResult Index()
        {
            ViewBag.RandomThing = "Not Cheese";
            return View();
        }
        public IActionResult History()
        {
            ViewBag.RandomThing = "Cheese";
            return View("History");
        }
        public RedirectToActionResult Contact()
        {
            return RedirectToAction("Messages");
        }
        [HttpGet]
        public IActionResult Messages()
        {
         
            MessageViewModel messageViewModel = new MessageViewModel() {
                CurrentUser = this.CurrentUser,
                Users = contactsRepo.Contacts,
                MessagesIncoming = messagesRepo.GetMessageToContact(this.CurrentUser),
                MessagesOutgoing= messagesRepo.GetMessageFromContact(this.CurrentUser)};

            return View("Messages", messageViewModel);
        }
        [HttpPost]
        public IActionResult Messages(string to, string emailAddress, string message, string subject,bool isPriority)
        {
            // Do message send here

            // then show result

            // if failed
            Message msg = new Message();
            msg.To = new User() { Name = to, EmailAddress = emailAddress };
            msg.From = new User() { Name = "self", EmailAddress = "me@example.com" };
            msg.Subject = subject;
            msg.Msge = message;
            msg.IsPriority = isPriority;


            return View("MessageSent",msg);
        }


    }
}
