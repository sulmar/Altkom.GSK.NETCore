using System;
using System.Collections;
using System.Collections.Generic;

namespace Altkom.GSK.Models
{
    public class Employee : Base
    {
        // prop
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? Birthday { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
