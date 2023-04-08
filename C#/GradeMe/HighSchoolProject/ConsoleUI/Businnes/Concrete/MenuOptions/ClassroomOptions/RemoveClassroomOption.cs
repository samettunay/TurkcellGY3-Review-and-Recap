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
    public class RemoveClassroomOption : IMenuOption
    {
        IClassroomService _classroomService;

        public RemoveClassroomOption(IClassroomService classroomService)
        {
            _classroomService = classroomService;
        }

        public void Execute()
        {
            var classrooms = _classroomService.GetAll();

            var classroom = NavigationLibrary.GetSelectedListItem("Silmek için sınıf [green]seçiniz[/]:", 20, classrooms);

            _classroomService.Delete(classroom.Id);
        }
    }
}
