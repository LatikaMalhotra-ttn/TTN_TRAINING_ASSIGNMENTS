using System;
using System.Collections.Generic;

namespace Day1_Assignment.Models
{
    public partial class Professor
    {
        public int Id { get; set; }
        public string ProfessorName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int? CourseId { get; set; }
        public int? PostId { get; set; }
        public int? PhoneNumber { get; set; }

        public virtual Course Course { get; set; }
        public virtual Post Post { get; set; }
    }
}
