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

            string firstName = SpectreConsoleHelper.ReadLineWithText("Öğrencinin ismini giriniz: ");
            string lastName = SpectreConsoleHelper.ReadLineWithText("Öğrencinin soyismini giriniz: ");
            int studentNumber = int.Parse(SpectreConsoleHelper.ReadLineWithText("Öğrencinin numarasını giriniz: "));

            Student studentToUpdate = new() { Id = student.Id, FirstName = firstName, LastName = lastName, StudentNumber = studentNumber };

            _studentService.Update(studentToUpdate);
        }
    }
}
