using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_lesson
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<SoftwareUpdate> SoftwareUpdates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                      .LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}
