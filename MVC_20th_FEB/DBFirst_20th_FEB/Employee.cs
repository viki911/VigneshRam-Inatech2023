using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.Models
{
    internal class Employee
    {
        public int EmployeeId { get; set; }

        public string? EmpName { get; set; }

        public DateTime? DateofBirth { get; set; }

        public string? Gender { get; set; }

        public int? DeptId { get; set; }

        public string? Designation { get; set; }

        public virtual Department? Dept { get; set; }
    }
}
