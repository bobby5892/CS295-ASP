using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace community.Models
{
    public class Location
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Name is required")]
        [StringLength(50, ErrorMessage = "Limited to 50 characters for Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Link is required")]
        [StringLength(200,ErrorMessage ="Limited to 200 characters for URL")]
        public string Link { get; set; }
    }
}
