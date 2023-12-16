using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab4
{
    public class AppDbContext : DbContext
    {
        public DbSet<Models.Composition> Compositions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=db.sqlite");
        }
    }
}
