using HouseRenting.Data.Data.Configurations;
using HouseRenting.Data.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRenting.Data.Data
{
    public class HouseRentingDbContext : IdentityDbContext
    {

        public HouseRentingDbContext
            (DbContextOptions<HouseRentingDbContext> options)
            : base(options)
        {
        }

        public DbSet<House> Houses { get; init; } = null!;
        public DbSet<Category> Categories { get; init; } = null!;
        public DbSet<Agent> Agents { get; init; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new AgentConfiguration());
            builder.ApplyConfiguration(new HouseConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
