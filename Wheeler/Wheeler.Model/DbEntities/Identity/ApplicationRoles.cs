using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wheeler.Model.DbEntities
{
    public class ApplicationRoles: IdentityRole
    {
        public ApplicationRoles() : base() { }
        public ApplicationRoles(string name) : base(name) { }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
    }
}
