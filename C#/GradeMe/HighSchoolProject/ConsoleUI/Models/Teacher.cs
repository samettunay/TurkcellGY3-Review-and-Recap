using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Models
{
    public class Teacher : Person, IModel
    {
        public Guid Id { get; set; }
        public string Department { get; set; }
        public override string ToString()
        {
            return $"[red]Ad Soyad:[/] {FirstName} {LastName} [red]Bölüm:[/] {Department}";
        }
    }
}
