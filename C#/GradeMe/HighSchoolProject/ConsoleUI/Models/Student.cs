﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleUI.Models
{
    public class Student : Person, IModel
    {
        public int Id { get; set; }
        public int StudentNumber { get; set; }
        public List<Homework>? Homeworks { get; set; }

        public override string ToString()
        {
            return $"[red]Numara:[/] {StudentNumber} [red]Ad Soyad:[/] {FirstName} {LastName}";
        }
    }
}
