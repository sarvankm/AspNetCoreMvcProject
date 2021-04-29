using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string CountryCity { get; set; }
        [NotMapped,Required]
        public IFormFile File { get; set; }
        public bool IsDeleted { get; set; }

    }
}
