﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Altkom.GSK.DbServices.Migrations
{
    public partial class AddPasswordToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");
        }
    }
}
