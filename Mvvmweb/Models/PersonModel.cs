using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvvmweb.Models
{
    public class PersonModel
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Range(18, 60)]
        public int Age { get; set; }


    }
}
