using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Utilities.Helpers;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.TeacherOptions
{
    public class AddTeacherOption : IMenuOption
    {
        ITeacherService _teacherService;

        public AddTeacherOption(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public void Execute()
        {
            string firstName = SpectreConsoleHelper.ReadLineWithText("Öğretmenin ismini giriniz: ");
            string lastName = SpectreConsoleHelper.ReadLineWithText("Öğretmenin soyismini giriniz: ");
            string department = SpectreConsoleHelper.ReadLineWithText("Öğretmenin bölümünü giriniz: ");

            Teacher teacher = new() { Id = Guid.NewGuid(), FirstName = firstName, LastName = lastName, Department = department };

            _teacherService.Add(teacher);
        }
    }
}
