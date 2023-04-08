using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Utilities.Helpers;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.TeacherOptions
{
    public class GetTeachersOption : IMenuOption
    {
        ITeacherService _teacherService;

        public GetTeachersOption(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public void Execute()
        {
            _teacherService.GetAll().ForEach(t => AnsiConsole.MarkupLine($"[red]Ad Soyad:[/] {t.FirstName} {t.LastName} [red]Bölüm:[/] {t.Department}"));
        }
    }
}
