using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using community.Models;
namespace community.Repositories
{
    public interface IContactRepository
    {
        List<User> Contacts { get; }
        void AddUser(User user);
        User GetUserByName(string name);
        void AddTestData();
    }
}
