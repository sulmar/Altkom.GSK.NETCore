﻿// <auto-generated />
using System;
using Altkom.GSK.DbServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Altkom.GSK.DbServices.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20181219092657_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Altkom.GSK.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("Altkom.GSK.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Birthday");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<int?>("GroupId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("ManagerId");

                    b.Property<decimal?>("Salary");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Altkom.GSK.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Altkom.GSK.Models.Device", b =>
                {
                    b.HasOne("Altkom.GSK.Models.Employee")
                        .WithMany("Devices")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("Altkom.GSK.Models.Employee", b =>
                {
                    b.HasOne("Altkom.GSK.Models.Group")
                        .WithMany("Employees")
                        .HasForeignKey("GroupId");

                    b.HasOne("Altkom.GSK.Models.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");
                });
#pragma warning restore 612, 618
        }
    }
}
