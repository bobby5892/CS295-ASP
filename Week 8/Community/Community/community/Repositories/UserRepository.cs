using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using community.Models;
namespace community.Repositories
{
    public class UserRepository
    {
        AppDBContext context;
        public UserRepository(AppDBContext context)
        {
            this.context = context;
        }
        public List<User> Users { get { return context.Users.ToList<User>(); } }

        public void AddUser(User newUser){
            this.context.Add(newUser);
            this.context.SaveChanges();
        }
    }
}
