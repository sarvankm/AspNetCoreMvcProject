using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.ViewModels
{
    public class BlogVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int CommentCount { get; set; } = 0;
        [Required]
        public string BlogContent { get; set; }

    }
}
