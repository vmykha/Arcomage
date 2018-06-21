﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User : IdentityUser
    {        
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        public ICollection<Score> Scores { get; set; }
             = new List<Score>();
    }
}
