using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace community.Models
{
    public class Message
    {
        public int ID { get; set; }
        public User To { get; set; }
        public User From { get; set; }
        public DateTime Timestamp { get; set; }
        public string Msge { get; set; }
        public string Subject { get; set; } 
        public bool IsPriority { get; set; }

       public Message()
        {
            // Set Default
            this.IsPriority = false;
            this.Timestamp =  DateTime.Now;
        }
    }
}
