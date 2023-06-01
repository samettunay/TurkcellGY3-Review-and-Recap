using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Utilities.Helpers;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
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
            string firstName = SpectreConsoleHelper.ReadLineWithText("Öğrencinin ismini giriniz: ");
            string lastName = SpectreConsoleHelper.ReadLineWithText("Öğrencinin soyismini giriniz: ");

            Student student = new() { Id = Guid.NewGuid(), FirstName = firstName, LastName = lastName, Homeworks = new()};

            _studentService.Add(student);
        }
    }
}
