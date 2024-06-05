using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace praktika3kurs.Models
{
    public class RealEstateContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Demand> Demands { get; set; }
        public DbSet<TypeObject> TypeObjects { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Agent> Agents { get; set; }

        public RealEstateContext(DbContextOptions<RealEstateContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Deal>()
                .HasKey(d => new { d.DemandId, d.SupplyId });

            modelBuilder.Entity<Deal>()
                .HasOne(d => d.Demand)
                .WithMany()
                .HasForeignKey(d => d.DemandId);

            modelBuilder.Entity<Deal>()
                .HasOne(d => d.Supply)
                .WithMany()
                .HasForeignKey(d => d.SupplyId);
        }
    }
}
