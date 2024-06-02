using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Data
{
    internal class Abcontext : DbContext
    {
        public DbSet<People> People { get; set; }
        public string ConnectionString { get; set; }

        public Abcontext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=Panna;Trusted_Connection=true");
        }
    }
}
