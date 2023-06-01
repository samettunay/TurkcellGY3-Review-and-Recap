using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Utilities;
using ConsoleUI.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.ClassroomOptions
{
    public class AddStudentInClassroomOption : IMenuOption
    {
        IClassroomService _classroomService;
        IStudentService _studentService;
        public AddStudentInClassroomOption(IClassroomService classroomService, IStudentService studentService)
        {
            _classroomService = classroomService;
            _studentService = studentService;
        }

        public void Execute()
        {
            var classrooms = _classroomService.GetAll();
            var students = _studentService.GetAll();

            var classroom = NavigationLibrary.GetSelectedListItem("Bir sınıf [green]seçiniz[/]:", 20, classrooms);
            var student = NavigationLibrary.GetSelectedListItem("Bir öğrenci [green]seçiniz[/]:", 20, students);

            _classroomService.AddStudentInClassroom(classroom, student);
        }
    }
}
