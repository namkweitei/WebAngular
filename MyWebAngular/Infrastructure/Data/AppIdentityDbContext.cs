using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebAngular.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MyWebAngular.Infrastructure.Data
{
    public class AppIdentityDbContext : IdentityDbContext<Users>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
