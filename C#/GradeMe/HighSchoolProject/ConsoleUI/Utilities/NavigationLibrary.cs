using ConsoleUI.StaticData;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Utilities
{
    public static class NavigationLibrary
    {
        public static string CreateMainMenu()
        {
            return AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Bir işlem [green]seçiniz[/]:")
                .PageSize(20)
                .AddChoiceGroup(AppConstants.ClassroomOperations, AppConstants.ClassroomNavigation)
                .AddChoiceGroup(AppConstants.TeacherOperations, AppConstants.TeacherNavigation)
                .AddChoiceGroup(AppConstants.StudentOperations, AppConstants.StudentNavigation)
                .AddChoiceGroup(AppConstants.HomeworkOperations, AppConstants.HomeworkNavigation)
            );
        }
    }
}