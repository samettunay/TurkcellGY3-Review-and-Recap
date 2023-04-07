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
            int classroomCode = ConsoleHelper.ReadIntWithText(PromptMessages.EnterClassroomCode);
            int responsibleTeacherId = ConsoleHelper.ReadIntWithText(PromptMessages.EnterClassroomResponsibleTeacherId);
            Teacher responsibleTeacher = _teacherService.GetById(responsibleTeacherId);
            Classroom classroom = new() { Id = 1, ClassNumber = classroomCode, ResponsibleTeacher = responsibleTeacher, Students = new() };
            _classroomService.Add(classroom);
        }
    }
}
