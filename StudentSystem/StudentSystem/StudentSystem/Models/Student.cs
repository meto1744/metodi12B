using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Student
    {
        public Student()
        {
            this.StudentCourses = new HashSet<StudentCourse>();
            this.HomeworkSubmissions = new HashSet<HomeworkSubmission>();
        }

        public int StudentId { get; set; }
        [Required]
        
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]

        public int PhoneNumber { get; set; }
        [MaxLength(10)]
        [MinLength(10)]

        
        public DateTime RegisteredOn { get; set; }
        [Required]

        public DateTime Birthday { get; set; }
        

        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<HomeworkSubmission> HomeworkSubmissions { get; set; }
    }
}
