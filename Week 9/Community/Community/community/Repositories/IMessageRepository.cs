using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using community.Models;

namespace community.Repositories
{
    public interface IMessageRepository
    {
        List<Message> Messages { get; }
        void AddMessage(Message message);
        List<Message> GetMessageToContact(User user);
        List<Message> GetMessageFromContact(User user);
        void AddTestData(List<User> contacts);
    }
}
