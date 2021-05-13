using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wheeler.Model.DbEntities
{
    public class ApplicationUsers : IdentityUser
    {
        public ApplicationUsers() : base() { }
        public bool IsActive { get; set; }

        public virtual AppUsers  AppUsers{ get; set; }
    }
}
