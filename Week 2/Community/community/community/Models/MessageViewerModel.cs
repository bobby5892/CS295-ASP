using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace community.Models
{
    public class MessageViewerModel
    {
        public UserModel currentUser;
        public List<MessageModel> messagesIncoming = new List<MessageModel>();
        public List<MessageModel> messagesOutgoing = new List<MessageModel>();
        public List<UserModel> users = new List<UserModel>();
    }
}
