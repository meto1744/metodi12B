using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class HomeworkSubmission
    {
        public HomeworkSubmission()
        {
           this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        [Required]

        public string Content { get; set; }
        [Required]

        public string ContentType { get; set; }
        [Required]

        public DateTime SubmissionTime { get; set; }
        [Required]

        public int StudentId { get; set; }
        [Required]

        public int CourseId { get; set; }
        [Required]


        public ICollection<Course> Courses { get; set; }
    }
}
