using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Model
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }

        public double Salary { get; set; }

        public List<Project> Projects { get; set; }
    }
}
