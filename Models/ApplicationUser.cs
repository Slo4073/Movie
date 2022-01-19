using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MovieTickets.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name ="Full name")]
        public String FullName { get; set; }
    }
}
