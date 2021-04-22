using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wheeler.Database.Context
{
    public sealed class WhelerDbContext:DbContext
    {
        public WhelerDbContext(DbContextOptions options) : base(options) { }
    }
}
