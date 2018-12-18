using Altkom.GSK.IServices;
using Altkom.GSK.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Altkom.GSK.DbServices
{

    
    public class DbEmployeesService : IEmployeesService
    {
        private readonly MyContext context;

        public DbEmployeesService(MyContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));

            // utworzenie bazy danych jesli nie istnieje
            context.Database.EnsureCreated();
        }

        public void Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public ICollection<Employee> Get()
        {
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
