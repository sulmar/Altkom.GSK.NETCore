using Altkom.GSK.FakeServices.Fakers;
using Altkom.GSK.IServices;
using Altkom.GSK.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Altkom.GSK.FakeServices
{
    // PM: Install-Package Bogus
    public class FakeEmployeesService : IEmployeesService
    {
        private ICollection<Employee> employees;

        public FakeEmployeesService()
        {
            EmployeeFaker employeeFaker = new EmployeeFaker();

            employees = employeeFaker.Generate(100);
        }

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public ICollection<Employee> Get()
        {
            return employees;
        }

        public Employee Get(int id)
        {
            return employees.SingleOrDefault(e => e.Id == id);
        }

        public Employee GetByName(string firstName)
        {
            return employees.FirstOrDefault(e => e.FirstName == firstName);
        }

        public void Remove(int id)
        {
            Employee employee = Get(id);

            employees.Remove(employee);
        }
    }
}
