using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class ManagementStudent
    {
        public int TotalStudent { get; set; }
        public List<Student> Students = new List<Student>();
        public void CinStudents()
        {
            Console.WriteLine("Enter total student");
            TotalStudent = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < TotalStudent; i++)
            {
                Student student = new Student();
                student.CinStudent();
                Students.Add(student);
            }
        }
        public void CoutStudents()
        {
            foreach(Student student in Students)
            {
                student.CoutStudent();
            }
        }
        public void SortStudent()
        {
            this.Students.Sort(new CompareScore());
        }
        public ManagementStudent()
        {
        }
    }
}
