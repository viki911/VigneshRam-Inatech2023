using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace CoreEM.Models
{
    internal class LeagueContext:DbContext
    {
        private const string connectionString = "Server=(localdb)\\ProjectModels;Database=Tournament; Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<League> League { get; set; }
    }
}
