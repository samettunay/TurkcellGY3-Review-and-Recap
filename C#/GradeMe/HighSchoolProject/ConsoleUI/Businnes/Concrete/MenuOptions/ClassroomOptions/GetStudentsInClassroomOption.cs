using ConsoleUI.Businnes.Abstract;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities.Helpers;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.ClassroomOptions
{
    public class GetStudentsInClassroomOption : IMenuOption
    {
        IClassroomService _classroomService;

        public GetStudentsInClassroomOption(IClassroomService classroomService)
        {
            _classroomService = classroomService;
        }

        public void Execute()
        {
            int classroomId = ConsoleHelper.ReadIntWithText(PromptMessages.EnterClassroomCode);
            var classroom = _classroomService.GetById(classroomId);
            foreach (var student in classroom.Students)
            {
                AnsiConsole.WriteLine($"{classroom.ClassNumber}, {student.FirstName}, {student.LastName}, {student.StudentNumber}");
            }
        }
    }
}
