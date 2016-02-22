﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsApproved { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? DOB { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<ContactDetail> ContactDetails { get; set; }

      
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
