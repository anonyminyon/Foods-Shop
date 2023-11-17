using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PRN211_HE171691_FOODSHOP.Models
{
    public partial class PRN211_FA23_SE1733Context : DbContext
    {
        public static PRN211_FA23_SE1733Context INSTANCE = new PRN211_FA23_SE1733Context();
        public PRN211_FA23_SE1733Context()
        {
            if (INSTANCE == null) { INSTANCE = this; }
        }

        public PRN211_FA23_SE1733Context(DbContextOptions<PRN211_FA23_SE1733Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountHe171691> AccountHe171691s { get; set; } = null!;
        public virtual DbSet<CategoriesHe171691> CategoriesHe171691s { get; set; } = null!;
        public virtual DbSet<ImageProductHe171691> ImageProductHe171691s { get; set; } = null!;
        public virtual DbSet<OrderDetailsHe171691> OrderDetailsHe171691s { get; set; } = null!;
        public virtual DbSet<OrdersHe171691> OrdersHe171691s { get; set; } = null!;
        public virtual DbSet<ProductHe171691> ProductHe171691s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            if (!optionsBuilder.IsConfigured) 
            { optionsBuilder.UseSqlServer(config.GetConnectionString("PRN211_FA23_SE1733Context")); }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountHe171691>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("Account_HE171691_pk");

                entity.ToTable("Account_HE171691");

                entity.Property(e => e.AccId).HasColumnName("accID");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Email)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(225)
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.UserName)
                    .HasMaxLength(225)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<CategoriesHe171691>(entity =>
            {
                entity.HasKey(e => e.CategoriesId)
                    .HasName("Categories_HE171691_pk");

                entity.ToTable("Categories_HE171691");

                entity.Property(e => e.CategoriesId).HasColumnName("categoriesID");

                entity.Property(e => e.CategoriesName)
                    .HasMaxLength(225)
                    .HasColumnName("categoriesName");
            });

            modelBuilder.Entity<ImageProductHe171691>(entity =>
            {
                entity.HasKey(e => e.ImageId)
                    .HasName("ImageProduct_HE171691_pk");

                entity.ToTable("ImageProduct_HE171691");

                entity.Property(e => e.ImageId).HasColumnName("imageID");

                entity.Property(e => e.ImagePath).HasColumnName("imagePath");

                entity.Property(e => e.ProductProductId).HasColumnName("Product_productID");

                entity.HasOne(d => d.ProductProduct)
                    .WithMany(p => p.ImageProductHe171691s)
                    .HasForeignKey(d => d.ProductProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Image_HE171691_Product_HE171691");
            });

            modelBuilder.Entity<OrderDetailsHe171691>(entity =>
            {
                entity.HasKey(e => e.OrderdetailId)
                    .HasName("OrderDetails_HE171691_pk");

                entity.ToTable("OrderDetails_HE171691");

                entity.Property(e => e.OrderdetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("orderdetailID");

                entity.Property(e => e.OrdersOrderId).HasColumnName("Orders_orderID");

                entity.Property(e => e.ProductProductId).HasColumnName("Product_productID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SubTotal).HasColumnName("subTotal");

                entity.Property(e => e.UnitPrice).HasColumnName("unitPrice");

                entity.HasOne(d => d.OrdersOrder)
                    .WithMany(p => p.OrderDetailsHe171691s)
                    .HasForeignKey(d => d.OrdersOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderDetails_HE171691_Orders_HE171691");

                entity.HasOne(d => d.ProductProduct)
                    .WithMany(p => p.OrderDetailsHe171691s)
                    .HasForeignKey(d => d.ProductProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderDetails_HE171691_Product_HE171691");
            });

            modelBuilder.Entity<OrdersHe171691>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("Orders_HE171691_pk");

                entity.ToTable("Orders_HE171691");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.AccountAccId).HasColumnName("Account_accID");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("orderDate");

                entity.Property(e => e.TotalAmount).HasColumnName("totalAmount");

                entity.HasOne(d => d.AccountAcc)
                    .WithMany(p => p.OrdersHe171691s)
                    .HasForeignKey(d => d.AccountAccId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Orders_HE171691_Account_HE171691");
            });

            modelBuilder.Entity<ProductHe171691>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("Product_HE171691_pk");

                entity.ToTable("Product_HE171691");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.CategoriesCategoriesId).HasColumnName("Categories_categoriesID");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(225)
                    .HasColumnName("productName");

                entity.Property(e => e.StockQuantity).HasColumnName("stockQuantity");

                entity.HasOne(d => d.CategoriesCategories)
                    .WithMany(p => p.ProductHe171691s)
                    .HasForeignKey(d => d.CategoriesCategoriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Product_HE171691_Categories_HE171691");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
