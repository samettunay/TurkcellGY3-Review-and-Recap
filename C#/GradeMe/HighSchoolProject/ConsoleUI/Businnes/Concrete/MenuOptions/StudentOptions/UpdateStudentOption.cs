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
    public class UpdateStudentOption : IMenuOption
    {
        IStudentService _studentService;

        public UpdateStudentOption(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void Execute()
        {
            int studentId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentIdToUpdate));
            string firstName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentName);
            string lastName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentLastName);
            int studentNumber = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentNumber));
            Student studentToUpdate = new() { Id = studentId, FirstName = firstName, LastName = lastName, StudentNumber = studentNumber };
            _studentService.Update(studentToUpdate);
        }
    }
}
