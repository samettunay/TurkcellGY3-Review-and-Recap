using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities;
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
            var students = _studentService.GetAll();

            var student = NavigationLibrary.GetSelectedListItem("Güncellenecek ödevi [green]seçiniz[/]:", 20, students);

            string firstName = SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentName);
            string lastName = SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentLastName);
            int studentNumber = int.Parse(SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentNumber));

            Student studentToUpdate = new() { Id = student.Id, FirstName = firstName, LastName = lastName, StudentNumber = studentNumber };

            _studentService.Update(studentToUpdate);
        }
    }
}
