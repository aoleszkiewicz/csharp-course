using ClubMembership.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubMembership.Data;

public class ClubMembershipDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}clubmembership.db");
        base.OnConfiguring(optionsBuilder);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FirstName).IsRequired();
            entity.Property(e => e.LastName).IsRequired();
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.PhoneNumber).IsRequired();
            entity.Property(e => e.DateOfBirth).IsRequired();
            entity.Property(e => e.StreetAddress).IsRequired();
            entity.Property(e => e.City).IsRequired();
            entity.Property(e => e.PostCode).IsRequired();
        });
    }
}