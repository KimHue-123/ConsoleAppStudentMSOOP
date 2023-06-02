using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class CompareScore : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if(x == null || y == null)
                return 0;
            if(x.AverageScore > y.AverageScore)
                return 1;
            if (y.AverageScore > x.AverageScore)
                return -1;
            return 0;
        }
    }
}
