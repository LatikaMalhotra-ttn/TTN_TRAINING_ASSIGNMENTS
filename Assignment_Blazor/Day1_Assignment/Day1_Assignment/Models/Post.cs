using System;
using System.Collections.Generic;

namespace Day1_Assignment.Models
{
    public partial class Post
    {
        public Post()
        {
            Professor = new HashSet<Professor>();
        }

        public int Id { get; set; }
        public string PostName { get; set; }

        public virtual ICollection<Professor> Professor { get; set; }
    }
}
