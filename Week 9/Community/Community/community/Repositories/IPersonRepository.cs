using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using community.Models;
namespace community.Repositories
{
    public interface IPersonRepository
    {
        List<Person> Persons { get; }
        void AddUser(Person newPerson);
    }
}
