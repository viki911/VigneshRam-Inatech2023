using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_console.Models
{
    internal class ProductContext:DbContext

    {
        private const string connectionString = "Server=(localdb)\\ProjectModels;Database=ProdCore; Trusted_Connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Product> Products { get; set;}
        public DbSet<ProductBatch> ProductBatchs { get; set;}

        public DbSet<ForKey> ForKeys { get; set;}

        public DbSet<Kkey> Kkeys { get; set;}
    }
}
