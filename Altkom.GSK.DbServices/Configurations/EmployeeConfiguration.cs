using Altkom.GSK.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.GSK.DbServices.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .HasKey(p => p.Id);

            //builder
            //    .HasKey(p => new { p.FirstName, p.LastName });

            builder
                .Property(p => p.FirstName)
                .HasMaxLength(50);

            builder
                .Property(p => p.LastName)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
