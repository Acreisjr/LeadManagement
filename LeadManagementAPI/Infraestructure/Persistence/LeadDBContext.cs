using Microsoft.EntityFrameworkCore;
using LeadManagementAPI.Models;

namespace LeadManagementAPI.Data
{
    public class LeadDbContext : DbContext
    {
        public LeadDbContext(DbContextOptions<LeadDbContext> options) : base(options) { }
        public DbSet<Lead> Leads { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lead>()
                .Property(l => l.Price)
                .HasColumnType("decimal(18,2)"); // 👈 Garante precisão para valores decimais

            base.OnModelCreating(modelBuilder);
        }
    }


}
