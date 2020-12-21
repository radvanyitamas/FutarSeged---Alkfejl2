using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FutarSeged.Models;

namespace FutarSeged.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FutarSeged.Models.Food> Foods { get; set; }
        public DbSet<FutarSeged.Models.AddressModel> Address { get; set; }
        public DbSet<FutarSeged.Models.OrderModel> Order { get; set; }
    }
}
