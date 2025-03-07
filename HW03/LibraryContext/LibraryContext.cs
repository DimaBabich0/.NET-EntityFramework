﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace LibraryContext
{
    public partial class LibraryContextDb : DbContext
    {
        public LibraryContextDb()
        {
        }

        public LibraryContextDb(DbContextOptions<LibraryContextDb> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Group> Groups { get; set; }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Temp> Temps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseLazyLoadingProxies().UseSqlite("Data Source=D:\\ВУЗ\\.NET C#\\SQLiteDatabases\\Library.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_Groups_Name").IsUnique();

                entity.Property(e => e.Count).HasDefaultValue(10);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Age).HasDefaultValue(17);
                entity.Property(e => e.IdGroups).HasColumnName("Id_Groups");

                entity.HasOne(d => d.IdGroupsNavigation).WithMany(p => p.Students)
                    .HasForeignKey(d => d.IdGroups)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Temp");

                entity.Property(e => e.AuthorsId).HasColumnName("Authors_Id");
                entity.Property(e => e.BooksId).HasColumnName("Books_Id");

                entity.HasOne(d => d.Authors).WithMany()
                    .HasForeignKey(d => d.AuthorsId)
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(d => d.Books).WithMany()
                    .HasForeignKey(d => d.BooksId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}

