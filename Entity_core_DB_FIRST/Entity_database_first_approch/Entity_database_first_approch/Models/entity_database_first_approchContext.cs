using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity_database_first_approch.Models
{
    public partial class entity_database_first_approchContext : DbContext
    {
        public entity_database_first_approchContext()
        {
        }

        public entity_database_first_approchContext(DbContextOptions<entity_database_first_approchContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCustomer> TblCustomer { get; set; }
        public virtual DbSet<TblOrder> TblOrder { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=entity_database_first_approch;User id=SA;Password=Programmer@4;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.ToTable("tblCustomer");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZipPin).HasColumnName("Zip_Pin");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.ToTable("tblOrder");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblOrder)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__tblOrder__Custom__3C69FB99");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblOrder)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__tblOrder__Produc__3D5E1FD2");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.ToTable("tblProduct");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
