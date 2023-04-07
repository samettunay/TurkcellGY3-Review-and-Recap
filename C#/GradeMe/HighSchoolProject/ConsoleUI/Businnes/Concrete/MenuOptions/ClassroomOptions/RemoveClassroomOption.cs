using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
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
            int classroomId = ConsoleHelper.ReadIntWithText(PromptMessages.EnterClassroomIdToDelete);
            Classroom classroomToDelete = _classroomService.GetById(classroomId);
            _classroomService.Delete(classroomToDelete);
        }
    }
}
