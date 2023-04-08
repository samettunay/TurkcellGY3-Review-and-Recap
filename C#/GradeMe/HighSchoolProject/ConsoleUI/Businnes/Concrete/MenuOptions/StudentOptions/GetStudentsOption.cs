using ConsoleUI.Businnes.Abstract;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.StudentOptions
{
    public class GetStudentsOption : IMenuOption
    {
        IStudentService _studentService;

        public GetStudentsOption(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void Execute()
        {
            _studentService.GetAll().ForEach(s => AnsiConsole.MarkupLine($"[red]Numara:[/] {s.StudentNumber} [red]Ad Soyad:[/] {s.FirstName} {s.LastName}"));
        }
    }
}
