using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.TeacherOptions
{
    public class RemoveTeacherOption : IMenuOption
    {
        ITeacherService _teacherService;

        public RemoveTeacherOption(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public void Execute()
        {
            int teacherId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherIdToDelete));
            Teacher teacherToDelete = _teacherService.GetById(teacherId);
            _teacherService.Delete(teacherToDelete);
        }
    }
}
