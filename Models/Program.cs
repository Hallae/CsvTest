using System;
using CsvTest.Models;
using Microsoft.EntityFrameworkCore;

namespace CsvTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EmployeeContext())
            {
                // Create a new employee
                var employee = new Employee
                {
                    name = "John Doe",
                    DateOfBirth = new DateTime(1994, 5, 15),
                    PassportSeries = 1234,
                    PassportNumber = 56789
                };

                // Add the employee to the database
                context.Employees.Add(employee);
                context.SaveChanges();

                Console.WriteLine("Employee added successfully!");
            }




            using (var context = new OrganizationContext())
            {
                // Create a new organization
                var organization = new Organization("Orbiters", "123 Main St, Anytown, USA", "123 Main St, Anytown, USA");

                // Add the organization to the database
                context.Organization.Add(organization);
                context.SaveChanges();

                Console.WriteLine("Organization added successfully!");
            }
        }
    }
}
