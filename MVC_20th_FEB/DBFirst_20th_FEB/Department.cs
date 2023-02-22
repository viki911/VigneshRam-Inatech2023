using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.Models
{
    internal class Department
    {
        public int DepartmentId { get; set; }

        public string? DepartmentName { get; set; }

        public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
    }
}
