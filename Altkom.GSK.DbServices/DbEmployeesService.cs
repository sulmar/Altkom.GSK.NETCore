using Altkom.GSK.IServices;
using Altkom.GSK.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Altkom.GSK.DbServices
{
    // Install-Package Microsoft.EntityFrameworkCore.Tools

    public class DbEmployeesService : IEmployeesService
    {
        private readonly MyContext context;

        public DbEmployeesService(MyContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));

            // utworzenie bazy danych jesli nie istnieje

            // context.Database.EnsureDeleted();
            // context.Database.EnsureCreated();

            context.Database.Migrate();
        }

        public void Add(Employee employee)
        {

            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public ICollection<Employee> Get()
        {
            //return context.Employees
            //    .FromSql("select * from dbo.Employees")
            //    .ToList();


            return context.Employees.ToList();
        }

        public Employee Get(int id)
        {
           // return context.Employees.SingleOrDefault(e=>e.FirstName == )
            return context.Employees.Find(id);
        }

        public void Remove(int id)
        {
            Employee employee = Get(id);
            context.Employees.Remove(employee);
            context.SaveChanges();
        }
    }
}
