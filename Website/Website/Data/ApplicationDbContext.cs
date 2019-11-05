using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Website.Models;

namespace Website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Website.Models.Education> Education { get; set; }
        public DbSet<Website.Models.Experience> Experience { get; set; }

        public DbSet<Website.Models.Skill> Skill { get; set; }
    }
}
