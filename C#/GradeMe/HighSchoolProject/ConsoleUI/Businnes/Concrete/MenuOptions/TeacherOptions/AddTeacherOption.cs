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
    public class AddTeacherOption : IMenuOption
    {
        ITeacherService _teacherService;

        public AddTeacherOption(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public void Execute()
        {
            string firstName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherName);
            string lastName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherLastName);
            string department = ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherDepartment);

            Teacher teacher = new() { Id = 1, FirstName = firstName, LastName = lastName, Department = department };

            _teacherService.Add(teacher);
        }
    }
}
