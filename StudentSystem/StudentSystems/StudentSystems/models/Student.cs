using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystems.models
{
    class Student
    {
        public Student()
        {
            this.StudentCourses = new HashSet<StudentCourse>();
        }
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]

        public int PhoneNumber { get; set; }

        

        public DateTime RegisteredOn { get; set; }

        public DateTime Birthday { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
