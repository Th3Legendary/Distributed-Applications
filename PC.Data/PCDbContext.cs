using Microsoft.EntityFrameworkCore;
using PC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PC.Data
{
    public class PCDbContext : DbContext
    {
        public PCDbContext(DbContextOptions<PCDbContext> options) : base(options)
        {

        }

        public DbSet<BuildList> BuildLists { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<Motherboard> Motherbaords { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<PSU> PSUs { get; set; }

    }
}
