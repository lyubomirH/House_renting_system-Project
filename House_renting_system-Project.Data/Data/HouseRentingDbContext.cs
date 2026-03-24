using House_renting_system_Project.Data.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace House_renting_system_Project.Data.Data
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<House>()
                .HasOne(h => h.Category)
                .WithMany(c => c.Houses)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<House>()
                .HasOne(h => h.Agent)
                .WithMany(a => a.ManagedHouses)
                .HasForeignKey(h => h.AgentId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    
    }
}
