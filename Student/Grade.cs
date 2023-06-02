using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Grade
    {
        public string Subject { get; set; }
        public double Score { get; set; }
        public Grade(string subject, double score)
        {
            Subject = subject;
            Score = score;
        }
        public Grade()
        {
        }
        public void CinGrade()
        {
            Console.Write("Enter subject name: ");
            Subject = Console.ReadLine();
            Console.Write("Enter score: ");
            Score = Convert.ToDouble(Console.ReadLine());
        }
    }
}
