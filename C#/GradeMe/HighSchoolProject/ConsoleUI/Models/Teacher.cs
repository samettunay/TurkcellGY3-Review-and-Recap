using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Models
{
    public class Teacher : Person
    {
        public int Id { get; set; }
        public string Department { get; set; }
    }
}
