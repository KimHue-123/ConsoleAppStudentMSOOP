using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Program
    {
        static void Main(string[] args)
        {
            ManagementStudent management = new ManagementStudent();
            management.CinStudents();
            management.CoutStudents();
            management.SortStudent();
            Console.WriteLine("-------------------Sort------------------");
            management.CoutStudents();
            Console.ReadLine();
        }
    }
}
