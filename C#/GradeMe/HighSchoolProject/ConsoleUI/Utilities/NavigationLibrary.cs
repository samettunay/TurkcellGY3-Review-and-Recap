using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
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
            var mainMenuPrompt = new SelectionPrompt<string>()
                .Title("Bir işlem seçiniz:")
                .PageSize(30);

            mainMenuPrompt.AddChoiceGroup(SchoolOperations.Classrooms, SchoolOperations.ClassroomMenuItems);
            mainMenuPrompt.AddChoiceGroup(SchoolOperations.Teachers, SchoolOperations.TeacherMenuItems);
            mainMenuPrompt.AddChoiceGroup(SchoolOperations.Students, SchoolOperations.StudentMenuItems);
            mainMenuPrompt.AddChoiceGroup(SchoolOperations.Homeworks, SchoolOperations.HomeworkMenuItems);

            return AnsiConsole.Prompt(mainMenuPrompt);
        }

        public static T GetSelectedListItem<T>(string title, int pageSize, List<T> modelList)
        {
            var item = AnsiConsole.Prompt(
            new SelectionPrompt<T>()
                .Title(title)
                .PageSize(pageSize)
                .AddChoices(modelList));

            return item;
        }
    }
}