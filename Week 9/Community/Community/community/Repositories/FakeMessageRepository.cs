using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using community.Models;

namespace community.Repositories
{
    public class FakeMessageRepository : IMessageRepository
    {
        private List<Message> msgs = new List<Message>();
        public List<Message> Messages { get { return msgs; } }
        public FakeMessageRepository()
        {
            AddTestData(new List<User> {
                new User() {Name="Tom",EmailAddress="tom@example.com" },
                new User() {Name="Taco",EmailAddress="taco@example.com" },
                new User() {Name="T",EmailAddress="t@example.com" },
                new User() {Name="Tim",EmailAddress="tim@example.com" },
                new User() {Name="Todd",EmailAddress="todd@example.com" },
                new User() {Name="Tad",EmailAddress="tad@example.com" },
                new User() {Name="Taft",EmailAddress="taft@example.com" }
            });
        }
        public void AddMessage(Message message)
        {
            this.msgs.Add(message);
        }
        /// <summary>
        /// Grab All Messages to a certain user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<Message> GetMessageToContact(User user)
        {
            List<Message> response = new List<Message>();
            this.Messages.ForEach(
                msg =>
                {
                    if (msg.To == user)
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
            this.msgs.ForEach(
                msg =>
                {
                    if (msg.From == user)
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
                    if (++count <= contacts.Count)
                    {
                        msgs.Add(new Message() { From = contacts[0], To = contacts[--count], Msge = "Hey " + contacts[count] + ", whats up" });

                    }
                    count++;
                }
            );
        }
    }
}
