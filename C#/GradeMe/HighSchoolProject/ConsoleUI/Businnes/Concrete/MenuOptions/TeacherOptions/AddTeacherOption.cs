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
            string firstName = SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherName);
            string lastName = SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherLastName);
            string department = SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherDepartment);

            Teacher teacher = new() { FirstName = firstName, LastName = lastName, Department = department };

            _teacherService.Add(teacher);
        }
    }
}
