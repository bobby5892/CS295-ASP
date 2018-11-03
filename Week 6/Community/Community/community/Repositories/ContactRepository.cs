using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using community.Models;

namespace community.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private List<User> contacts = new List<User>();
        public List<User> Contacts  { get{ return contacts;} }

        public void AddUser(User user)
        {
            this.contacts.Add(user);        }

        public User GetUserByName(string name)
        {
            User found = null;
            this.contacts.ForEach( user => {
                if(user.Name == name)
                {
                    found = user;
                }
            });
            return found;
        }
        public void AddTestData()
        {
            contacts.Add(new User() { EmailAddress = "bob@example.com", Name = "Bob B." }); 
            contacts.Add(new User() { EmailAddress = "bill@example.com", Name = "Bill B." });
            contacts.Add(new User() { EmailAddress = "steve@example.com", Name = "Steve B." });
            contacts.Add(new User() { EmailAddress = "stan@example.com", Name = "Stan B." });
            contacts.Add(new User() { EmailAddress = "doug@example.com", Name = "Doug B." });
        }
    }
}
