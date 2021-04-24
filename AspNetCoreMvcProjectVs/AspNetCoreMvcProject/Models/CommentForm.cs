using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class CommentForm
    {
     
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Massage { get; set; }
        [Required]
        public int BlogId { get; set; }
        [Required]
        public virtual Blog Blog { get; set; }


    }
}
