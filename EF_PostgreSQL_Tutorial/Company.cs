using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_PostgreSQL_Tutorial
{
    public class Company
    {
        public Company()
        {
            Employees = new HashSet<Employee>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int YearFounded { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
