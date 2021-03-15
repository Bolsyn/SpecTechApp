using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecTechApp.Data
{
    public class TechContext : DbContext
    {
        public TechContext()
        {
            Database.Migrate();
        }

        public DbSet<> {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ; Database = SpecTechApp; Trusted_Connection = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
        }
    }
}
