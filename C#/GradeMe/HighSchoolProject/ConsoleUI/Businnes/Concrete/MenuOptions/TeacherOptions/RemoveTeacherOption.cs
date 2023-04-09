using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Utilities;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.TeacherOptions
{
    public class RemoveTeacherOption : IMenuOption
    {
        ITeacherService _teacherService;

        public RemoveTeacherOption(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public void Execute()
        {
            var teachers = _teacherService.GetAll();

            var teacher = NavigationLibrary.GetSelectedListItem("Silinecek öğretmeni [green]seçiniz[/]:", 20, teachers);

            _teacherService.Delete(teacher.Id);
        }
    }
}
