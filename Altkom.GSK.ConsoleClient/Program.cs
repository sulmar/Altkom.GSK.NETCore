using Altkom.GSK.FakeServices;
using Altkom.GSK.IServices;
using System;

namespace Altkom.GSK.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IEmployeesService employeesService = new FakeEmployeesService();

            var employees = employeesService.Get();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
