using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvTest.Models
{
    public class OrganizationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-10A2V02;Database=OrganizationConsoledb;Trusted_Connection=True;");
        }
        public DbSet<Organization> Organization { get; set; }

    }
}
