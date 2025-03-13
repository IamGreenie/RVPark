using ApplicationCore.Models;
using System.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Site> Sites { get; set; }
    public DbSet<SiteType> SiteTypes { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<PCSOrder> PCSOrders { get; set; }
    public DbSet<Report> Reports { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<TransactionInformation> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Define relationships
        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.Site)
            .WithMany(s => s.Reservations)
            .HasForeignKey(r => r.SiteId)
            .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder);
    }
}
