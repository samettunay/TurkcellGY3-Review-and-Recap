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

namespace ConsoleUI.Businnes.Concrete.MenuOptions.ClassroomOptions
{
    public class UpdateClassroomOption : IMenuOption
    {
        IClassroomService _classroomService;
        ITeacherService _teacherService;

        public UpdateClassroomOption(IClassroomService classroomService, ITeacherService teacherService)
        {
            _classroomService = classroomService;
            _teacherService = teacherService;
        }

        public void Execute()
        {
            var classrooms = _classroomService.GetAll();

            var classroom = NavigationLibrary.GetSelectedListItem("Güncellemek için sınıf [green]seçiniz[/]:", 20, classrooms);

            var teachers = _teacherService.GetAll();

            var teacher = NavigationLibrary.GetSelectedListItem("Sorumlu öğretmeni [green]seçiniz[/]:", 20, teachers);

            Classroom classroomToUpdate = new() { Id = classroom.Id, ClassNumber = classroom.ClassNumber, ResponsibleTeacher = teacher, Students = classroom.Students };

            _classroomService.Update(classroomToUpdate);
        }
    }
}
