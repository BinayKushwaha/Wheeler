using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wheeler.Database.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base(){ }
        public ApplicationRole(string name) : base(name) { }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
    }
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }
        public bool IsDeleted { get; set; }
    }
}
