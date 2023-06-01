using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Utilities;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.TeacherOptions
{
    public class AddHomeworkToStudentOption : IMenuOption
    {
        ITeacherService _teacherService;
        IStudentService _studentService;
        IHomeworkService _homeworkService;
        public AddHomeworkToStudentOption(ITeacherService teacherService, IStudentService studentService, IHomeworkService homeworkService)
        {
            _teacherService = teacherService;
            _studentService = studentService;
            _homeworkService = homeworkService;
        }

        public void Execute()
        {
            var students = _studentService.GetAll();
            var homeworks = _homeworkService.GetAll();

            var student = NavigationLibrary.GetSelectedListItem("Bir öğrenci [green]seçiniz[/]:", 20, students);
            var homework = NavigationLibrary.GetSelectedListItem("Bir ödev [green]seçiniz[/]:", 20, homeworks);

            _teacherService.AddHomeworkToStudent(student.Id, homework.Id);
        }
    }
}
