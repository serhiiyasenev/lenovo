using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct1
{
    public struct Employee
    {
        public Employee (int empId, string name, string department)
        {
            this.EmpId = empId;
            this.Name = name;
            this.Department = department;
        }
        public int EmpId;
        public string Name;
        public string Department;
    }
}
