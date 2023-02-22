using DbFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    internal class Program
    {
        public static void InsertDepartment()
        {
            using (var dv = new DatabaseContext())
            {
                Department dpt = new Department();
                dpt.DepartmentName = "ECE";
                dv.Add(dpt);
                dv.SaveChanges();
                dpt = new Department();
                dpt.DepartmentName = "CSE";
                dv.Add(dpt);
                dv.SaveChanges();


            }


        }
        public static void InsertEmployee()
        {
            using (var emp = new DatabaseContext())
            {
                Employee em = new Employee();
                em.EmpName = "Ram";
                em.DateofBirth = Convert.ToDateTime(02 / 03 / 2001);
                em.Gender = "M";
                em.DeptId = 1;
                em.Designation = "HR";
                emp.Add(em);
                em = new Employee();
                em.EmpName = "Siya";
                em.DateofBirth = Convert.ToDateTime(09 / 09 / 2000);
                em.Gender = "F";
                em.DeptId = 2;
                em.Designation = "CEO";
                emp.Add(em);
                emp.SaveChanges();

            }
        }
        public static void Main(string[] args)
        {
            //InsertDepartment();
            InsertEmployee();
        }
    }
}