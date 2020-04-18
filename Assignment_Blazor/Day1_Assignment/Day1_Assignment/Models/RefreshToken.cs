﻿using System;
using System.Collections.Generic;

namespace Day1_Assignment.Models
{
    public partial class RefreshToken
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Token { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public virtual Users User { get; set; }
    }
}
