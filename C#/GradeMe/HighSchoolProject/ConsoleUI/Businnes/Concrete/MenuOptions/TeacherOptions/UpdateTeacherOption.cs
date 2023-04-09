using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Utilities;
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
    internal class UpdateTeacherOption : IMenuOption
    {
        ITeacherService _teacherService;

        public UpdateTeacherOption(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public void Execute()
        {
            var teachers = _teacherService.GetAll();

            var teacher = NavigationLibrary.GetSelectedListItem("Güncellenecek öğretmeni [green]seçiniz[/]:", 20, teachers);

            string firstName = SpectreConsoleHelper.ReadLineWithText("Öğretmenin ismini giriniz: ");
            string lastName = SpectreConsoleHelper.ReadLineWithText("Öğretmenin soyismini giriniz: ");
            string department = SpectreConsoleHelper.ReadLineWithText("Öğretmenin bölümünü giriniz: ");

            Teacher teacherToUpdate = new() { Id = teacher.Id, FirstName = firstName, LastName = lastName, Department = department };
            _teacherService.Update(teacherToUpdate);
        }
    }
}
