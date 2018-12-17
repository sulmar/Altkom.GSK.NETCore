using Altkom.GSK.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.GSK.FakeServices.Fakers
{
    class EmployeeFaker : Faker<Employee>
    {

        // ctor
        public EmployeeFaker()
        {
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
            RuleFor(p => p.Birthday, f => f.Person.DateOfBirth);
            RuleFor(p => p.Salary, f => f.Finance.Amount(1500, 2000));
            RuleFor(p => p.IsActive, f => f.Random.Bool(0.8f));
        }

    }
}
