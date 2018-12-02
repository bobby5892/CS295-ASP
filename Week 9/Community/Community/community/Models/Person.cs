using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace community.Models
{
    public class Person
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(20,ErrorMessage ="20 character max name length")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Must include Link")]
        [StringLength(200,ErrorMessage = "Limited to 200 characters")]
        public string Link { get; set; }
    }
}
