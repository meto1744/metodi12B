using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class StudentCourse
    {
       public int StudentId { get; set; }

        public Student Students { get; set; }

        public int CourseId { get; set; }

        public Course Courses { get; set; }
    }
}
