﻿using MyApp.Domain.Entities.Music;
using MyApp.Domain.Entities.Management;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<CD> CDs { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection", options =>
                options.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .HasMany(a => a.CDs)
                .WithOne(c => c.Album)
                .HasForeignKey(c => c.AlbumId);

            modelBuilder.Entity<CD>()
                .HasMany(c => c.Tracks)
                .WithOne(t => t.CD)
                .HasForeignKey(t => t.CDId);
        }
    }
}
