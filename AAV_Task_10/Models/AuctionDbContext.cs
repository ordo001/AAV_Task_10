using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AAV_Task_10.Models
{
    public class AuctionDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<TypeItem> TypeItems { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=gogs.wsr.ru;Initial Catalog=Auction_AAV;User ID=587-22;Password=587-22;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Item);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Buyer)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Item>()
                .HasOne(i => i.TypeItem);

            modelBuilder.Entity<Item>()
                .HasOne(i => i.OwnerItem)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
