using Altkom.GSK.IServices;
using Altkom.GSK.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Altkom.GSK.Service.Controllers
{
    [Route("api/pracownicy")]
    [Route("api/[controller]")]
    [ApiController]
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

        [HttpHead("{id}")]
        public IActionResult Head(int id)
        {
            var employee = employeesService.Get(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var employee = employeesService.Get(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpGet("{name:alpha}")]
        public IActionResult Get(string name)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            employeesService.Add(employee);

            return CreatedAtRoute(new { id = employee.Id }, employee);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            employeesService.Remove(id);

            return Ok();
        }


    }
}
