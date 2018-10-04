using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using community.Models;
using System.Web;

namespace community.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult History()
        {
            return View("History");
        }
        public RedirectToActionResult Contact()
        {
            return RedirectToAction("Messages");
        }
        [HttpGet]
        public IActionResult Messages()
        {
            /* Hard Coded - Normally we would pull from entity framework and then we would have users as a list of user as users*/
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel() { emailAddress = "bob@example.com", name = "Bob B." }); // 0
            users.Add(new UserModel() { emailAddress = "bill@example.com", name = "Bill B." });
            users.Add(new UserModel() { emailAddress = "steve@example.com", name = "Steve B." });
            users.Add(new UserModel() { emailAddress = "stan@example.com", name = "Stan B." });
            users.Add(new UserModel() { emailAddress = "doug@example.com", name = "Doug B." });

            UserModel currentUser = users[0];

            List<MessageModel> messagesSent = new List<MessageModel>();
            // Sent Messages
            messagesSent.Add(new MessageModel(){from=users[0],to=users[1],message="Hey Bill, whats up"});
            messagesSent.Add(new MessageModel() { from = users[0], to = users[2], message = "Hey Steve, whats up" });
            messagesSent.Add(new MessageModel() { from = users[0], to = users[3], message = "Hey Stan, whats up" });
            // To Messages
            List<MessageModel> messagesReceived = new List<MessageModel>();
            messagesReceived.Add(new MessageModel() { from = users[3], to = users[0], message = "Hey Bob, this is Stan. " });
            messagesReceived.Add(new MessageModel() { from = users[4], to = users[0], message = "Hey Bob, this is Doug. " });
            messagesReceived.Add(new MessageModel() { from = users[2], to = users[0], message = "Hey Bob, this is Steve. " });

            // Now lets wrap it up in our ViewModel

            MessageViewerModel messageViewModel = new MessageViewerModel() { currentUser=currentUser,users=users,
                messagesIncoming = messagesReceived,
            messagesOutgoing=messagesSent};

            return View("Messages", messageViewModel);
        }
        [HttpPost]
        public IActionResult Messages(string to, string emailAddress, string message)
        {
            // Do message send here

            // then show result

            // if failed
            MessageModel msg = new MessageModel();
            msg.to = new UserModel() { name = to, emailAddress = emailAddress };
            msg.from = new UserModel() { name = "self", emailAddress = "me@example.com" };
            msg.message = message;


            return View("MessageSent",msg);
        }


    }
}
