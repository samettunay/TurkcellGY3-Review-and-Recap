using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities;
using ConsoleUI.Utilities.Helpers;
using Microsoft.VisualBasic;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.StudentOptions
{
    public class GetStudentHomeworksOption : IMenuOption
    {
        IStudentService _studentService;

        public GetStudentHomeworksOption(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void Execute()
        {
            var students = _studentService.GetAll();

            var student = NavigationLibrary.GetSelectedListItem("Ödev eklenecek öğrenciyi [green]seçiniz[/]:", 20, students);

            List<Homework> homeworks = student.Homeworks;

            if (homeworks != null)
                foreach (var homework in homeworks)
                {
                    AnsiConsole.MarkupLine($"[red]Öğrenci No:[/] {student.StudentNumber} [red]Başlık:[/] {homework.Title} [red]Açıklama:[/] {homework.Description} [red]Son Teslim:[/] {homework.DueDate}");
                }
        }
    }
}
