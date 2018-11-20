using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using community.Models;
namespace community.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        AppDBContext context;
        public PersonRepository(AppDBContext context)
        {
            this.context = context;
        }
        public List<Person> Persons { get { return context.Persons.ToList<Person>(); } }

        public void AddUser(Person newPerson)
        {
            this.context.Add(newPerson);
            this.context.SaveChanges();
        }
    }
}
