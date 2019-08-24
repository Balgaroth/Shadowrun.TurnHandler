using System;
using Microsoft.EntityFrameworkCore;
using Shadowrun.Sql.Models;

namespace Shadowrun.Sql
{
    public class ShadowrunDbContext : DbContext
    {
        private readonly string _connectionString;

        public ShadowrunDbContext()
        {
            _connectionString = "Server=LAPTOP-U9COE1IG\\SQLEXPRESS;Database=Shadowrun;User Id=stianadmin;Password=changeYourPassword1";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (_connectionString == null)
                {
                    throw new Exception("Database connection string missing.");
                }

                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        public DbSet<Entity> Entities { get; set; }
    }
}
