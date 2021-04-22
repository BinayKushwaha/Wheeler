using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Wheeler.Database.Identity;

namespace Wheeler.Database.Context
{
    public sealed class ContextSeed
    {
        private WhelerDbContext Context { get; }
        public ContextSeed(WhelerDbContext context) {
            Context = context;
        }
        public static void SeedUserAndRole(IServiceProvider serviceProvider)
        {

            var roleStore = new RoleStore<ApplicationRole>(Context);
        }
    }
}
