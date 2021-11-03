using Microsoft.EntityFrameworkCore;
using MSTraining_ProductCatalog.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSTraining_ProductCatalog.Persistence.Contexts
{
    public class ProductCatalogContext : DbContext
    {
        public ProductCatalogContext(DbContextOptions<ProductCatalogContext> options) : base(options)
        {
        }

        public DbSet<ProductEF> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEF>().ToTable("Products");
        }
    }
}
