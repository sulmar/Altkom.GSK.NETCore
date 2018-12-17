using Altkom.GSK.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Altkom.GSK.IServices
{
    public interface IEmployeesService
    {
        ICollection<Employee> Get();
        Employee Get(int id);
    }
}
