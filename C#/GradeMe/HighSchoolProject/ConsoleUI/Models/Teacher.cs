﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Models
{
    public class Teacher : Person, IModel
    {
        public int Id { get; set; }
        public string Department { get; set; }
    }
}
