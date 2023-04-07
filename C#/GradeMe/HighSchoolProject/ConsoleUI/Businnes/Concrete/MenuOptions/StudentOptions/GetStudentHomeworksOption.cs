using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities.Helpers;
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
            int studentId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentId));
            List<Homework> homeworks = _studentService.GetStudentHomeworks(studentId);

            if (homeworks.Count == 0)
            {
                AnsiConsole.WriteLine($"Student with Id {studentId} has no homeworks");
            }
            else
            {
                AnsiConsole.WriteLine($"Homeworks of the student with Id {studentId}:");
                foreach (var homework in homeworks)
                {
                    AnsiConsole.WriteLine($"- {homework.Title}: {homework.Description}");
                }
            }
        }
    }
}
