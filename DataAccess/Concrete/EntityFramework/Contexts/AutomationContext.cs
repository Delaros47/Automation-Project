using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class AutomationContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StockGroup>().HasKey(c=>c.GroupId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4HHFM4J\DEVELOPER;Initial Catalog=AutomationDb;Integrated Security=True;");
        }

        public DbSet<StockGroup> StockGroups { get; set; }
        public DbSet<Stock> Stocks { get; set; }




    }
}
