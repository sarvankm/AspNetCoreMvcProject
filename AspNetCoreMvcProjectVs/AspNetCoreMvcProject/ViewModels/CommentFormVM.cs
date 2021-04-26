using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.ViewModels
{
    public class CommentFormVM
    {
        [Required]
        public string Name { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Massage { get; set; }
    }
}
