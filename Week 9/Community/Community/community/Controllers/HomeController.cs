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

           
            if (contactRepo.Contacts.Count == 0)
            {
                // Temp until we have login via Microsoft Identities
                contactRepo.AddUser(
                new User() {
                    EmailAddress = "bob@bobville.com",Name="Bob"
                });

            }
            User temp = contactRepo.Contacts[0];
            CurrentUser.Name = temp.Name;
            CurrentUser.EmailAddress = temp.EmailAddress;
            CurrentUser.ID = temp.ID;
          
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
        [HttpGet]
        public IActionResult ManageContacts()
        {
            return View("Contacts");
        }
        [HttpPost]
        public IActionResult ManageContacts(string name, string emailAddress)
        {
            contactsRepo.AddUser(new Models.User() { Name = name, EmailAddress = emailAddress });
            
            return View("Contacts");
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
            
            // then show result

            // if failed
            Message msg = new Message();

         
            msg.To = contactsRepo.GetUserByEmail(emailAddress);
            // If contact doesn't exist - add it
            if(msg.To == null)
            {
                contactsRepo.AddUser(new Models.User() { Name = to, EmailAddress = emailAddress });
                msg.To = contactsRepo.GetUserByEmail(emailAddress);
            }   
            msg.From = CurrentUser;
            msg.Subject = subject;
            msg.Msge = message;
            msg.IsPriority = isPriority;

            // Do message send here
            messagesRepo.AddMessage(msg);


            return View("MessageSent",msg);
        }


    }
}
