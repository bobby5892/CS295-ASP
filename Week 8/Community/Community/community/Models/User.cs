using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace community.Models
{
    public class User : IComparable,IEquatable<User>
    {
      
        public int ID { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public int CompareTo(object obj)
        {
            // If null - lets cast it out
            if(obj == null) { return 1; }

            User compareUser = (User)obj;

            if (compareUser.ID == ID)
            {
                return 0;
            }
            else if(compareUser.ID > ID)
            {
                return -1;
            }
            else
            {
                return 1;
            }
          
        }

        public bool Equals(User other)
        {
           return (ID == other.ID);
        }
    }
}
