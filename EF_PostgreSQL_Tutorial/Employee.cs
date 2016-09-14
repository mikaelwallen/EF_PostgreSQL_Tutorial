using System;
using System.ComponentModel.DataAnnotations;

namespace EF_PostgreSQL_Tutorial
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Company Company { get; set; }
        public DateTime HireDate { get; set; }
        public string Department { get; set; }
    }
}
