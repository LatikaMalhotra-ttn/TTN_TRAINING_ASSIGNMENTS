using System;
using System.Collections.Generic;

namespace Day1_Assignment.Models
{
    public partial class Course
    {
        public Course()
        {
            Professor = new HashSet<Professor>();
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<Professor> Professor { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
