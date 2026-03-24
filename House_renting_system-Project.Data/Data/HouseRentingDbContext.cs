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
    }
}
