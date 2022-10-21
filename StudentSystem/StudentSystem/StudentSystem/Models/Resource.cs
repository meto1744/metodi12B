using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Resource
    {
        public Resource()
        {
            this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        [MaxLength(50)]

        public int Url { get; set; }
        [Required]


        public string ResourseType { get; set; }
        [Required]

        public int CourseId { get; set; }
        [Required]

        public ICollection<Course> Courses { get; set; }
    }
}
