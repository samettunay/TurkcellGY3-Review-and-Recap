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

namespace ConsoleUI.Businnes.Concrete.MenuOptions.ClassroomOptions
{
    public class AddClassroomOption : IMenuOption
    {
        IClassroomService _classroomService;
        ITeacherService _teacherService;
        public AddClassroomOption(IClassroomService classroomService, ITeacherService teacherService)
        {
            _classroomService = classroomService;
            _teacherService = teacherService;
        }

        public void Execute()
        {
            int classroomNumber = SpectreConsoleHelper.ReadIntWithText("Sınıfın numarasını giriniz: ");

            var teachers = _teacherService.GetAll();

            var teacher = NavigationLibrary.GetSelectedListItem("Sorumlu öğretmeni [green]seçiniz[/]:", 20, teachers);

            Classroom classroom = new() { Id = Guid.NewGuid(), ClassNumber = classroomNumber, ResponsibleTeacher = teacher, Students = new() };
            _classroomService.Add(classroom);
        }
    }
}
