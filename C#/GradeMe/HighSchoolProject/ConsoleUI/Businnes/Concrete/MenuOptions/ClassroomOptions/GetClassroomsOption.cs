using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.ClassroomOptions
{
    public class GetClassroomsOption : IMenuOption
    {
        IClassroomService _classroomService;

        public GetClassroomsOption(IClassroomService classroomService)
        {
            _classroomService = classroomService;
        }
  
        public void Execute()
        {
            _classroomService.GetAll().ForEach(c => AnsiConsole.MarkupLine($"[red]Sınıfın numarası:[/] {c.ClassNumber} [red]Sorumlu Öğretmen:[/] {c.ResponsibleTeacher.FirstName} {c.ResponsibleTeacher.LastName} [red]Sınıfdaki öğrenci sayısı:[/] {c.Students.Count}"));
        }
    }
}
