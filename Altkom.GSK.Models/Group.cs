using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.GSK.Models
{
    public class Group : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
