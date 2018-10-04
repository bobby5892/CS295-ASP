using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace community.Models
{
    public class MessageModel
    {
        public UserModel to { get; set; }
        public UserModel from { get; set; }
        public DateTime timestamp { get; set; }
        public string message { get; set; }
    }
}
