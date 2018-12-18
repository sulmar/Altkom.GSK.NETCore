using Altkom.GSK.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.GSK.DbServices
{

    // Install-Package Microsoft.EntityFrameworkCore
    public class MyContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDb;Initial Catalog=MyDb;Integrated Security=true;";

            // Install-Package Microsoft.EntityFrameworkCore.SqlServer
            optionsBuilder.UseSqlServer(connectionString);


            base.OnConfiguring(optionsBuilder);
        }
    }
}
