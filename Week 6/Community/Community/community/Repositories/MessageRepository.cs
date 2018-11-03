﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using community.Models;

namespace community.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private List<Message> msgs = new List<Message>();
        public List<Message> Messages { get { return msgs;  } }

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
                    if (contacts[++count] != null)
                    {
                        msgs.Add(new Message() { From = contacts[0], To = contacts[--count], Msge = "Hey " + contacts[count] + ", whats up" });

                    }
                    count++;
                }
            );
        }
    }
}
