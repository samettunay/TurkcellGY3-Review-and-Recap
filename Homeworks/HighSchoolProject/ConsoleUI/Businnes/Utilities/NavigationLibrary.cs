using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Utilities
{
    public static class NavigationLibrary
    {
        public static string CreateMainMenu()
        {
            var mainMenuPrompt = new SelectionPrompt<string>()
                .Title("Bir işlem seçiniz:")
                .PageSize(30);

            mainMenuPrompt.AddChoiceGroup(MenuOptions.Classrooms, MenuOptions.ClassroomMenuOptions);
            mainMenuPrompt.AddChoiceGroup(MenuOptions.Teachers, MenuOptions.TeacherMenuOptions);
            mainMenuPrompt.AddChoiceGroup(MenuOptions.Students, MenuOptions.StudentMenuOptions);
            mainMenuPrompt.AddChoiceGroup(MenuOptions.Homeworks, MenuOptions.HomeworkMenuOptions);

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