using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class Form
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Massage { get; set; }
    }
}
