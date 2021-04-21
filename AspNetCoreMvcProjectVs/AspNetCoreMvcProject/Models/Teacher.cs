using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string About { get; set; }
     
        [Required]
        public string Degree { get; set; }
        [Required]
        public string Experience { get; set; }
        [Required]
        public string Hobbies { get; set; }
        [Required]
        public string Faculty { get; set; }
        [Required]
        public string ContactInfoMail { get; set; }
        [Required]
        public string ContactInfoSkype { get; set; }
        [Required]
        public string ContactInfoNumber { get; set; }
        [Required]
        public string OwnFacebook { get; set; }
        [Required]
        public string OwnPinterest { get; set; }
        [Required]
        public string OwnVimeo { get; set; }
        [Required]
        public string OwnTwitter { get; set; }
        [Required]
        public int SkillId { get; set; }
        [Required]
        public Skills Skills { get; set; }
    }
}
