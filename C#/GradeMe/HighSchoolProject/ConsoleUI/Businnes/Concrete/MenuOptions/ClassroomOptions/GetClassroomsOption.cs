using ConsoleUI.Businnes.Abstract;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.ClassroomOptions
{
    public class GetClassroomsOption : IMenuOption
    {
        IClassroomService _classroomService;

        public GetClassroomsOption(IClassroomService classroomService)
        {
            _classroomService = classroomService;
        }
  
        public void Execute()
        {
            _classroomService.GetAll().ForEach(c => AnsiConsole.WriteLine($"{c.Id}, {c.ClassNumber}, sorumlu öğretmen: {c.ResponsibleTeacher?.FirstName}"));
        }
    }
}
