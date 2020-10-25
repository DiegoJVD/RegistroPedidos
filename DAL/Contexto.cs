using Microsoft.EntityFrameworkCore;
using RegistroPedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroPedidos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Suplidores> Suplidores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(@"Data Source=Data/BDPedidos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Productos>().HasData(new List<Productos>()
                { 
                    new Productos(1, "pan", 75, 0),
                    new Productos(2, "soda", 30, 0),
                }
            );

            modelBuilder.Entity<Suplidores>().HasData(new List<Suplidores>()
                {
                    new Suplidores(1, "yoma"),
                    new Suplidores(2, "coca-cola"),
                }
            );
        }
    }
}