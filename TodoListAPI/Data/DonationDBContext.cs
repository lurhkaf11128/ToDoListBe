using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TodoListAPI.Models;

namespace TodoListAPI.Data
{
    public partial class DonationDBContext : DbContext
    {
        public DonationDBContext()
        {
        }

        public DonationDBContext(DbContextOptions<DonationDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dcandidate> Dcandidates { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Dcandidate>(entity =>
            {
                entity.ToTable("tablephptest");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Level)
                    .HasMaxLength(255)
                    .HasColumnName("level");

                entity.Property(e => e.Content)
                    .HasMaxLength(255)
                    .HasColumnName("content");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
