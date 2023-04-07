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
    public class AddHomeworkToAllStudentsInClassroomOption : IMenuOption
    {
        IClassroomService _classroomService;

        public AddHomeworkToAllStudentsInClassroomOption(IClassroomService classroomService)
        {
            _classroomService = classroomService;
        }

        public void Execute()
        {
            int classroomCode = ConsoleHelper.ReadIntWithText(PromptMessages.EnterClassroomCode);
            int homeworkId = ConsoleHelper.ReadIntWithText(PromptMessages.EnterHomeworkIdToAdd);
            _classroomService.AddHomeworkToAllStudentsInClassroom(classroomCode, homeworkId);
        }
    }
}
