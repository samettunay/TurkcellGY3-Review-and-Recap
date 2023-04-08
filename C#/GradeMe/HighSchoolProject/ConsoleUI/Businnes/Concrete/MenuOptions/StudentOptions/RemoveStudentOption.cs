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
    public class RemoveStudentOption : IMenuOption
    {
        IStudentService _studentService;

        public RemoveStudentOption(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void Execute()
        {
            var students = _studentService.GetAll();

            var student = NavigationLibrary.GetSelectedListItem("Silinecek ödevi [green]seçiniz[/]:", 20, students);

            _studentService.Delete(student.Id);
        }
    }
}
