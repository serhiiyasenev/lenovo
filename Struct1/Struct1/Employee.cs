namespace Struct1
{
    public struct Employee
    {
        public Employee (int empId, string name, string department)
        {
            EmpId = empId;
            Name = name;
            Department = department;
        }
        public int EmpId;
        public string Name;
        public string Department;
    }
}
