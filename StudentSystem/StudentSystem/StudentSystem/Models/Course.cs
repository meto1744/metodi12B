using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Course
    {
        public Course()
        {
            this.StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        [MaxLength(80)]

        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        [Required]

        public DateTime EndDate { get; set; }
        [Required]

        public double Price { get; set; }
        [Required]

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
