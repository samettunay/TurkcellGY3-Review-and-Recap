using ConsoleUI.Businnes.Abstract;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities.Helpers;
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

        public AddStudentInClassroomOption(IClassroomService classroomService)
        {
            _classroomService = classroomService;
        }

        public void Execute()
        {
            int classroomCode = ConsoleHelper.ReadIntWithText(PromptMessages.EnterClassroomCode);
            int studentId = ConsoleHelper.ReadIntWithText(PromptMessages.EnterStudentIdToAdd);
            _classroomService.AddStudentInClassroom(classroomCode, studentId);
        }
    }
}
