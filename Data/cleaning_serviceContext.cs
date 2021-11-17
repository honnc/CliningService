using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CleaningServiceWeb.Data.CleaningServiceModels;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CleaningServiceWeb.Data
{
    public partial class cleaning_serviceContext : DbContext
    {
        public cleaning_serviceContext()
        {
        }

        public cleaning_serviceContext(DbContextOptions<cleaning_serviceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cleaning> Cleanings { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=cleaning_service;Username=postgres;Password=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251@icu");

            modelBuilder.Entity<Cleaning>(entity =>
            {
                entity.HasKey(e => e.IdClean);

                entity.ToTable("Cleaning");

                entity.HasIndex(e => e.IdClient, "IX_Cleaning_id_client");

                entity.HasIndex(e => e.IdDoc, "IX_Cleaning_id_doc");

                entity.HasIndex(e => e.IdEml, "IX_Cleaning_id_eml");

                entity.HasIndex(e => e.IdOrder, "IX_Cleaning_id_order");

                entity.Property(e => e.IdClean)
                    .ValueGeneratedNever()
                    .HasColumnName("id_clean");

                entity.Property(e => e.DateClining)
                    .HasColumnType("date")
                    .HasColumnName("dateClining");

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdDoc).HasColumnName("id_doc");

                entity.Property(e => e.IdEml).HasColumnName("id_eml");

                entity.Property(e => e.IdOrder).HasColumnName("id_order");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Cleanings)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cleaning_Client");

                entity.HasOne(d => d.IdDocNavigation)
                    .WithMany(p => p.Cleanings)
                    .HasForeignKey(d => d.IdDoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cleaning_Document");

                entity.HasOne(d => d.IdEmlNavigation)
                    .WithMany(p => p.Cleanings)
                    .HasForeignKey(d => d.IdEml)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cleaning_Employees");

                entity.HasOne(d => d.IdOrderNavigation)
                    .WithMany(p => p.Cleanings)
                    .HasForeignKey(d => d.IdOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cleaning_Orders");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient);

                entity.ToTable("Client");

                entity.Property(e => e.IdClient)
                    .ValueGeneratedNever()
                    .HasColumnName("id_client");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Fioagent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FIOagent");

                entity.Property(e => e.NameCompany)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name_company");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("phoneNumber");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.IdDoc);

                entity.ToTable("Document");

                entity.HasIndex(e => e.IdEmp, "IX_Document_id_emp");

                entity.Property(e => e.IdDoc)
                    .ValueGeneratedNever()
                    .HasColumnName("id_doc");

                entity.Property(e => e.DateOrder)
                    .HasColumnType("date")
                    .HasColumnName("dateOrder");

                entity.Property(e => e.IdEmp).HasColumnName("id_emp");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.IdEmpNavigation)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.IdEmp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document_Employees");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmp);

                entity.Property(e => e.IdEmp)
                    .ValueGeneratedNever()
                    .HasColumnName("id_emp");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FIO");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.HasIndex(e => e.IdClient, "IX_Orders_id_client");

                entity.HasIndex(e => e.IdDoc, "IX_Orders_id_doc");

                entity.HasIndex(e => e.IdEmp, "IX_Orders_id_emp");

                entity.Property(e => e.IdOrder)
                    .ValueGeneratedNever()
                    .HasColumnName("id_order");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdDoc).HasColumnName("id_doc");

                entity.Property(e => e.IdEmp).HasColumnName("id_emp");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Client");

                entity.HasOne(d => d.IdDocNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdDoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Document");

                entity.HasOne(d => d.IdEmpNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdEmp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Employees");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
