using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.StudentOptions
{
    public class AddStudentOption : IMenuOption
    {
        IStudentService _studentService;

        public AddStudentOption(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void Execute()
        {
            string firstName = SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentName);
            string lastName = SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentLastName);
            int studentNumber = int.Parse(SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentNumber));

            Student student = new() { FirstName = firstName, LastName = lastName, StudentNumber = studentNumber, Homeworks = new()};

            _studentService.Add(student);
        }
    }
}
