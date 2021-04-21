using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class Skills
    {
        public int Id { get; set; }
        [Required]
        public int LanguageSkillPercent { get; set; }
        [Required]
        public int DesignSkillPercent { get; set; }
        [Required]
        public int TeamLeaderSkillPercent { get; set; }
        [Required]
        public int InnovationSkillPercent { get; set; }
        [Required]
        public int DevelopmentSkillPercent { get; set; }
        [Required]
        public int CommunicationSkillPercent { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public Teacher Teacher { get; set; }
    }
}
