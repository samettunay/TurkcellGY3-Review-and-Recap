using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Utilities;
using Microsoft.VisualBasic;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.TeacherOptions
{
    public class GetHomeworksOfStudentOption : IMenuOption
    {
        ITeacherService _teacherService;
        IStudentService _studentService;
        public GetHomeworksOfStudentOption(ITeacherService teacherService, IStudentService studentService)
        {
            _teacherService = teacherService;
            _studentService = studentService;
        }
        public void Execute()
        {
            var students = _studentService.GetAll();

            var student = NavigationLibrary.GetSelectedListItem("Bir öğrenci [green]seçiniz[/]:", 20, students);

            var homeworksOfStudent = _teacherService.GetHomeworksSelectedStudent(student);

            if (homeworksOfStudent != null)
                homeworksOfStudent.ForEach(h => AnsiConsole.MarkupLine($"[red]Öğrenci:[/] {student.FirstName} {student.LastName} [red]Başlık:[/] {h.Title} [red]Açıklama:[/] {h.Description} [red]Son Teslim:[/] {h.DueDate}"));
        }
    }
}
