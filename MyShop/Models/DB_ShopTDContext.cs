using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyShop.Models
{
    public partial class DB_ShopTDContext : DbContext
    {
        public DB_ShopTDContext()
        {
        }

        public DB_ShopTDContext(DbContextOptions<DB_ShopTDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Products> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.MenuId)
                    .HasColumnName("Menu_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.ParentId).HasColumnName("Parent_ID");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ProductId)
                    .HasColumnName("Product_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });
        }
    }
}
