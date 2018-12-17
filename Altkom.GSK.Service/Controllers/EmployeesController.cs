using Altkom.GSK.IServices;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Altkom.GSK.Service.Controllers
{
    [Route("api/pracownicy")]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            this.employeesService = employeesService;
        }

        [HttpGet("{name:alpha}/{field}")]
        public IActionResult GetTelBy(string name, string field)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Pobierz()
        {
            var employees = employeesService.Get();

            return Ok(employees);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var employee = employeesService.Get(id);

            return Ok(employee);
        }

        [HttpGet("{name:alpha}")]
        public IActionResult Get(string name)
        {
            throw new NotImplementedException();
        }


    }
}
