using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace community.Models
{
    public class MessageViewModel
    {
        public User CurrentUser;
        public List<Message> MessagesIncoming = new List<Message>();
        public List<Message> MessagesOutgoing = new List<Message>();
        public List<User> Users = new List<User>();
    }
}
