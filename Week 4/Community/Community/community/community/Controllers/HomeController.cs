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
            /* Hard Coded - Normally we would pull from entity framework and then we would have users as a list of user as users*/
            List<User> users = new List<User>();
            users.Add(new User() { EmailAddress = "bob@example.com", Name = "Bob B." }); // 0
            users.Add(new User() { EmailAddress = "bill@example.com", Name = "Bill B." });
            users.Add(new User() { EmailAddress = "steve@example.com", Name = "Steve B." });
            users.Add(new User() { EmailAddress = "stan@example.com", Name = "Stan B." });
            users.Add(new User() { EmailAddress = "doug@example.com", Name = "Doug B." });

            User currentUser = users[0];

            List<Message> messagesSent = new List<Message>();
            // Sent Messages
            messagesSent.Add(new Message(){From=users[0],To=users[1],Msge="Hey Bill, whats up"});
            messagesSent.Add(new Message() { From = users[0], To = users[2], Msge = "Hey Steve, whats up" ,IsPriority=true});
            messagesSent.Add(new Message() { From = users[0], To = users[3], Msge = "Hey Stan, whats up" });
            // To Messages
            List<Message> messagesReceived = new List<Message>();
            messagesReceived.Add(new Message() { From = users[3], To = users[0], Msge = "Hey Bob, this is Stan. " });
            messagesReceived.Add(new Message() { From = users[4], To = users[0], Msge = "Hey Bob, this is Doug. " ,IsPriority=true});
            messagesReceived.Add(new Message() { From = users[2], To = users[0], Msge = "Hey Bob, this is Steve. " });

            // Wk 3 - Sort with Lambda
            messagesReceived.Sort((msg1, msg2) => msg1.Timestamp.CompareTo(msg2.Timestamp));
            messagesSent.Sort((msg1, msg2) => msg1.Timestamp.CompareTo(msg2.Timestamp));

            // Now lets wrap it up in our ViewModel

            MessageViewModel messageViewModel = new MessageViewModel() { CurrentUser=currentUser,Users=users,
                MessagesIncoming = messagesReceived,
            MessagesOutgoing=messagesSent};

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
