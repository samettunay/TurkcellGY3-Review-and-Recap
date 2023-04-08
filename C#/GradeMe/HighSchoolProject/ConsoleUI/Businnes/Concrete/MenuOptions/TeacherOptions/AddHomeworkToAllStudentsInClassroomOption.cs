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

namespace ConsoleUI.Businnes.Concrete.MenuOptions.TeacherOptions
{
    public class AddHomeworkToAllStudentsInClassroomOption : IMenuOption
    {
        ITeacherService _teacherService;
        IClassroomService _classroomService;
        IHomeworkService _homeworkService;

        public AddHomeworkToAllStudentsInClassroomOption(ITeacherService teacherService, IClassroomService classroomService, IHomeworkService homeworkService)
        {
            _teacherService = teacherService;
            _classroomService = classroomService;
            _homeworkService = homeworkService;
        }

        public void Execute()
        {
            var classrooms = _classroomService.GetAll();
            var homeworks = _homeworkService.GetAll();

            var classroom = NavigationLibrary.GetSelectedListItem("Bir sınıf [green]seçiniz[/]:", 20, classrooms);
            var homework = NavigationLibrary.GetSelectedListItem("Bir ödev [green]seçiniz[/]:", 20, homeworks);


            _teacherService.AddHomeworkToAllStudentsInClassroom(classroom.Id, homework.Id);
        }
    }
}
