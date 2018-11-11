using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using community.Models;

namespace community.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        AppDBContext context;
        public MessageRepository(AppDBContext context)
        {
            this.context = context;
        }

        public List<Message> Messages { get { return context.Messages.ToList<Message>();  } }

        public void AddMessage(Message message)
        {
            this.context.Messages.Add(message);
            this.context.SaveChanges();
        }
        /// <summary>
        /// Grab All Messages to a certain user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<Message> GetMessageToContact(User user)
        {
            List<Message> response = new List<Message>();
            this.context.Messages.ToList<Message>().ForEach(
                msg =>
                {
                    if (msg.To.ID == user.ID)
                    {
                        response.Add(msg);
                    }
                });
            return response;
        }
        /// <summary>
        /// Get all messages from a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<Message> GetMessageFromContact(User user)
        {
            List<Message> response = new List<Message>();
            this.context.Messages.ToList<Message>().ForEach(
                msg =>
                {
                    if (msg.From.ID == user.ID)
                    {
                        response.Add(msg);
                    }
                });
            return response;
        }
        public void AddTestData(List<User> contacts)
        {
            int count = 0;
            contacts.ForEach(
                contact =>
                {
                    if (contacts[++count] != null)
                    {
                        context.Messages.Add(new Message() { From = contacts[0], To = contacts[--count], Msge = "Hey " + contacts[count] + ", whats up" });

                    }
                    count++;
                }
            );
        }
    }
}
