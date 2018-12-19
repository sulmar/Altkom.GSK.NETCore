using Altkom.GSK.DbServices.Configurations;
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


        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {

        }

     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .ApplyConfiguration(new EmployeeConfiguration())
                .ApplyConfiguration(new GroupConfiguration());


        }
    }
}
