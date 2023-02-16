using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EcommerceCore.Models
{
    public class User 
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Car> Cars { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

       // public ICollection<Role> Roles { get; set; }

    }
}
