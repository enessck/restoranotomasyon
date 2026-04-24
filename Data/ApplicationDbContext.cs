using Microsoft.EntityFrameworkCore;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RestaurantTable> RestaurantTables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=restorantotomasyonu;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Decimal precision için
            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Order>().Property(o => o.TotalAmount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Order>().Property(o => o.DiscountAmount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<OrderItem>().Property(oi => oi.Price).HasColumnType("decimal(18,2)");

            // Tablo isimlerini Türkçeleştirme
            modelBuilder.Entity<User>().ToTable("Kullanicilar");
            modelBuilder.Entity<Category>().ToTable("Kategoriler");
            modelBuilder.Entity<Product>().ToTable("Urunler");
            modelBuilder.Entity<RestaurantTable>().ToTable("Masalar");
            modelBuilder.Entity<Order>().ToTable("Siparisler");
            modelBuilder.Entity<OrderItem>().ToTable("SiparisDetaylari");
            modelBuilder.Entity<Customer>().ToTable("Musteriler");
            modelBuilder.Entity<Reservation>().ToTable("Rezervasyonlar");
        }
    }
}
