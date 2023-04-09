using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Utilities;
using ConsoleUI.StaticData;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.ClassroomOptions
{
    public class GetStudentsInClassroomOption : IMenuOption
    {
        IClassroomService _classroomService;

        public GetStudentsInClassroomOption(IClassroomService classroomService)
        {
            _classroomService = classroomService;
        }

        public void Execute()
        {
            var classrooms = _classroomService.GetAll();

            var classroom = NavigationLibrary.GetSelectedListItem("Bir sınıf [green]seçiniz[/]:", 20, classrooms);

            foreach (var student in classroom.Students)
            {
                AnsiConsole.MarkupLine($"[red]Sınıf No:[/] {classroom.ClassNumber} [red] Öğrenci:[/] {student.FirstName} {student.LastName}, {student.StudentNumber}");
            }
        }
    }
}
