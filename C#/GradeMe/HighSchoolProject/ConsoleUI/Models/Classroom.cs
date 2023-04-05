﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public int ClassNumber { get; set; }
        public Teacher? ResponsibleTeacher { get; set; }
        public List<Student>? Students { get; set; }
    }
}
