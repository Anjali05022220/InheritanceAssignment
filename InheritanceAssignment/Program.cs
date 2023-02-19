using InheritanceAssignment.InheritanceAssignment;
using System;

namespace InheritanceAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student =
            new Student(1, "Anjali", "Bhopal", 5547452, "1", 85, "A+", 50000);
            Console.WriteLine("Student Details :");
            Console.WriteLine("-----------------");
            student.Details();
           
            Console.WriteLine();


            TeachingStaff teachingstaff =
            new TeachingStaff(101, "Priyanka", "Tripura", 5612278, "HOD", 40000, "PHD", "CN");
            Console.WriteLine("Teaching Staff Details :");
            Console.WriteLine("------------------------");
            teachingstaff.Details();
            
            Console.WriteLine();

            NonTeachingStaff nonteachingstaff =
            new NonTeachingStaff(201, "Akash", "Mumbai", 956485288, "TG", 50000, "CSE", 101);
            Console.WriteLine("Non Teaching Staff Details :");
            Console.WriteLine("----------------------------");
            nonteachingstaff.Details();
            Console.WriteLine();
        }
    }
}
