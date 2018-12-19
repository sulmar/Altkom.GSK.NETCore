using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Altkom.GSK.Models
{
    public class Employee : Base
    {
        // prop

       // [Key]
        public int Id { get; set; }

       // [MaxLength(50)]
        public string FirstName { get; set; }

        //[MaxLength(50)]
        //[Required]
        public string LastName { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? Birthday { get; set; }
        public bool IsActive { get; set; }

        public Employee Manager { get; set; }
        public ICollection<Device> Devices { get; set; }
        // public ICollection<Group> Groups { get; set; }

        public string Password  { get; set; }
    }
}
