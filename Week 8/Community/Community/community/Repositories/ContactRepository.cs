using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using community.Models;

namespace community.Repositories
{
    public class ContactRepository : IContactRepository
    {
        AppDBContext context;
       
        public ContactRepository(AppDBContext context)
        {
            this.context = context;
        }
        
        public List<User> Contacts  { get{ return context.Users.ToList();} }

        public void AddUser(User user)
        {
            this.context.Users.Add(user);
            this.context.SaveChanges();
           
        }

        public User GetUserByName(string name)
        {
            User found = null;
            this.context.Users.ToList<User>().ForEach( user => {
                if(user.Name == name)
                {
                    found = user;
                }
            });
            return found;
        }
        public User GetUserByEmail(string email)
        {
            User found = null;
            this.context.Users.ToList<User>().ForEach(user => {
                if (user.EmailAddress == email)
                {
                    found = user;
                }
            });
            return found;
        }
        public void AddTestData()
        {
            AddUser(new User() { EmailAddress = "bob@example.com", Name = "Bob B." });
            AddUser(new User() { EmailAddress = "bill@example.com", Name = "Bill B." });
            AddUser(new User() { EmailAddress = "steve@example.com", Name = "Steve B." });
            AddUser(new User() { EmailAddress = "stan@example.com", Name = "Stan B." });
            AddUser(new User() { EmailAddress = "doug@example.com", Name = "Doug B." });
        }
    }
}
