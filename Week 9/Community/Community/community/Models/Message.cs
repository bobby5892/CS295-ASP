using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace community.Models
{
    public class Message
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Need To")]
        public User To { get; set; }

        [Required(ErrorMessage = "Need From")]
        public User From { get; set; }
        public DateTime Timestamp { get; set; }

        [Required(ErrorMessage = "Need Msg")]
        [StringLength(5000, ErrorMessage = "Messages are limited to 5000 characters")]
        public string Msge { get; set; }

        [Required(ErrorMessage = "Need Suject")]
        [StringLength(50,ErrorMessage = "Subject limited to 50 characters")]
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
