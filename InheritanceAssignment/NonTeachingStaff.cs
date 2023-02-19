using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssignment
{
    internal class NonTeachingStaff : Person
    {
        public string Designation { get; set; }
        public double Salary { get; set; }

        public string DepartmentName { get; set; }
        public int ManagerId { get; set; }

        public NonTeachingStaff(int id, string name, string address, int phone, string designation, double salary, string deptname, int managerid) : base(id, name, address, phone)
        {
            this.Designation = designation;
            this.Salary = salary;
            this.DepartmentName = deptname;
            this.ManagerId = managerid;
        }
        public override void Details()
        {
            base.Details();
            Console.WriteLine("Designation :" + Designation);
            Console.WriteLine("Salary :" + Salary);
            Console.WriteLine("Department Name :" + DepartmentName);
            Console.WriteLine("Manager Id :" + ManagerId);
        }
    }
}
