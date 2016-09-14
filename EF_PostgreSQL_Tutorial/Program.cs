using System;
using System.Linq;

namespace EF_PostgreSQL_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CompanyContext())
            {
                // Add a couple of companies and some employees.
                var company = new Company()
                {
                    Name = "MegaCorp",
                    YearFounded = 2000
                };
                context.CompanySet.Add(company);

                context.EmployeeSet.Add(new Employee()
                {
                    Name = "Andrew",
                    Company = company,
                    HireDate = new DateTime(2000, 01, 01)
                });
                context.EmployeeSet.Add(new Employee()
                {
                    Name = "John",
                    Company = company,
                    HireDate = new DateTime(2001, 10, 05)
                });

                company = new Company()
                {
                    Name = "EvilInc",
                    YearFounded = 1996
                };
                context.CompanySet.Add(company);

                context.EmployeeSet.Add(new Employee()
                {
                    Name = "Dr Evil",
                    Company = company,
                    HireDate = new DateTime(1996, 03, 20)
                });
                context.EmployeeSet.Add(new Employee()
                {
                    Name = "Minion",
                    Company = company,
                    HireDate = new DateTime(1996, 04, 07)
                });

                // Save/Commit changes to database.
                context.SaveChanges();

                // Print out the companies and their employees to the console.
                var companies = context.CompanySet.ToList();
                foreach (var c in companies)
                {
                    Console.WriteLine("Company " + c.Name + " founded in " + c.YearFounded);
                    foreach (var employee in c.Employees)
                    {
                        Console.WriteLine("  Name: " + employee.Name + " Hire Date: " + employee.HireDate);
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
