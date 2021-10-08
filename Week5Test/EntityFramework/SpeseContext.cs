using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Test.Models;
using Week5Test.EntityFramework.Configurations;

namespace Week5Test.EntityFramework
{

    public class SpeseContext : DbContext
    {
        //stringa connessione db
        private static IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

        //Costruttori
        public SpeseContext() : base()
        {

        }

        public SpeseContext(DbContextOptions<SpeseContext> options) : base(options)
        {

        }

        //DbSet
        public DbSet<Spese> setSpese { get; set; }
        public DbSet<Categorie> setCategorie { get; set; }

        //Metodi
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionStringSQL = config.GetConnectionString("Week5test");

                optionsBuilder.UseSqlServer(connectionStringSQL);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SpeseConfiguration());
            modelBuilder.ApplyConfiguration(new CategorieConfiguration());
        }


    }
}
