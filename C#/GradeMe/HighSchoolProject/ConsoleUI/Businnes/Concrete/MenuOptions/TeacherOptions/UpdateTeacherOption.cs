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
    internal class UpdateTeacherOption : IMenuOption
    {
        ITeacherService _teacherService;

        public UpdateTeacherOption(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public void Execute()
        {
            int teacherId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherIdToUpdate));
            string firstName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherName);
            string lastName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherLastName);
            string department = ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherDepartment);
            Teacher teacherToUpdate = new() { Id = teacherId, FirstName = firstName, LastName = lastName, Department = department };
            _teacherService.Update(teacherToUpdate);
        }
    }
}
