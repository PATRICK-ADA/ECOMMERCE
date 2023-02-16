using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCore.Models
{
    public class Role
    {
        public string Id { get; set; }
        public string RoleName { get; set; }

         public ICollection<UserRole> UserRoles { get; set; }
       // public ICollection<User> Users { get; set; }
    }
}
