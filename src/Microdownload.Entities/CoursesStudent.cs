﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microdownload.Entities
{
    public class CoursesStudent
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CoursesId { get; set; }
        public Courses Courses { get; set; }
    }
}
