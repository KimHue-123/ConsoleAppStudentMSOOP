using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        private static int CurentId = 0;
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public DateTime Dob { get; set; }
        public int TotalSubject { get; set; }
        List<Grade> Grades = new List<Grade>();
        public Double AverageScore { get { 
            if(Grades != null)
                {
                    Double score = 0;
                    foreach(Grade g in Grades)
                    {
                        score += g.Score;
                    }
                    return score/ Grades.Count;
                }
            return 0;
            } 
        }
        public Student(int studentId, string name, int age, string address, string sex, DateTime dob, int totalSubject, List<Grade> grades)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
            Address = address;
            Sex = sex;
            Dob = dob;
            TotalSubject = totalSubject;
            Grades = grades;
        }
        public Student()
        {
        }

        public void CinStudent()
        {
            StudentId = CurentId;
            CurentId++;
            Console.Write("Enter Student name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Student age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student sex: ");
            Sex = Console.ReadLine();
            Console.Write("Enter Student birthday: ");
            Dob = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter Student address: ");
            Address = Console.ReadLine();
            Console.Write("Enter total subject: ");
            TotalSubject = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < TotalSubject; i++)
            {
                Console.WriteLine("Enter information of subject");
                Grade grade = new Grade();
                grade.CinGrade();
                Grades.Add(grade);
            }

        }
        public void CoutStudent()
        {
            Console.WriteLine("Sutdent name: " + this.Name);
            Console.WriteLine("Sutdent age: " + this.Age);
            Console.WriteLine("Sutdent sex: " + this.Sex);
            Console.WriteLine("Sutdent address: " + this.Address);
            Console.WriteLine("Sutdent Dob: " + this.Dob);
            foreach(var item in Grades)
            {
                Console.WriteLine(item.Subject + ": , Score: " + item.Score);
            }
            
            Console.WriteLine("Average score: " + this.AverageScore);
        }
    }
}
