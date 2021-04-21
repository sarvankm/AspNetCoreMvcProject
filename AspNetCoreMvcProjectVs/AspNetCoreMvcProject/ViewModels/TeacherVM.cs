using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.ViewModels
{
    public class TeacherVM
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string OwnFacebook { get; set; }
        [Required]
        public string OwnPinterest { get; set; }
        [Required]
        public string OwnVimeo { get; set; }
        [Required]
        public string OwnTwitter { get; set; }
    }
}
