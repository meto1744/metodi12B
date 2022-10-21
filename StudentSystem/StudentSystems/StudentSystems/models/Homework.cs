using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystems.models
{
    public class Homework
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime SubmissionTime { get; set; }

        public int Studentid { get; set; }

        public int Courseid { get; set; }

    }
}
