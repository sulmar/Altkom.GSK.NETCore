using Altkom.GSK.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Altkom.GSK.IServices
{
    public interface IEmployeesService
    {
        void Add(Employee employee);
        ICollection<Employee> Get();
        Employee Get(int id);
        void Remove(int id);
    }
}
