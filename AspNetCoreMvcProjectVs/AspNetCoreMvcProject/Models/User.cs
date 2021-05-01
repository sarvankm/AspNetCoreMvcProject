﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class User:IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        public bool IsDeleted { get; set; }

    }
}
