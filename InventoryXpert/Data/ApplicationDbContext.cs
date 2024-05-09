using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InventoryXpert.Models;

namespace InventoryXpert.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<InventoryXpert.Models.Order>? Order { get; set; }
        public DbSet<InventoryXpert.Models.Category>? Category { get; set; }
        public DbSet<InventoryXpert.Models.Item>? Item { get; set; }
        public DbSet<InventoryXpert.Models.OrderRecord>? OrderRecord { get; set; }
        public DbSet<InventoryXpert.Models.Supplier>? Supplier { get; set; }
        public static string schema = "testSchema";

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Order", schema: schema);
            modelBuilder.Entity<Category>().ToTable("Category", schema: schema);
            modelBuilder.Entity<Item>().ToTable("Item", schema: "testSchema");
            modelBuilder.Entity<OrderRecord>().ToTable("OrderRecord", schema: schema);
            modelBuilder.Entity<Supplier>().ToTable("Supplier", schema: schema);
            base.OnModelCreating(modelBuilder);
        }
    }
}