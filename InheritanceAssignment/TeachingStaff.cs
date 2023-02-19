
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssignment
{
    internal class TeachingStaff : Person
    {
        
        public string Designation { get; set; }
        public int Salary { get; set; }
        public string Qualification { get; set; }
        public string Subject { get; set; }

        public TeachingStaff(int id, string name, string address,  int phone, string designation, int salary, string qualification, string subject) : base(id, name, address, phone)
        {
            //this.Id = staffid;
            this.Designation = designation;
            this.Salary = salary;
            this.Qualification = qualification;
            this.Subject = subject;
        }
        public override void Details()
        {
            base.Details();
            //Console.WriteLine("staffid " + StaffId);
            Console.WriteLine("Designation :" + Designation);
            Console.WriteLine("Salary :" + Salary);
            Console.WriteLine("Qualification :" + Qualification);
            Console.WriteLine("Subject :" + Subject);

        }
    }
}
