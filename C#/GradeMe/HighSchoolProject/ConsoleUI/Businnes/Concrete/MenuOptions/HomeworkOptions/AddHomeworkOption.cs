using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities.Helpers;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.HomeworkOptions
{
    public class AddHomeworkOption : IMenuOption
    {
        IHomeworkService _homeworkService;

        public AddHomeworkOption(IHomeworkService homeworkService)
        {
            _homeworkService = homeworkService;
        }

        public void Execute()
        {
            string title = SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkTitle);
            string description = SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkDescription);
            DateTime dueDate = SpectreConsoleHelper.ReadDateTimeWithText(PromptMessages.EnterHomeworkDueDate);

            Homework homeworkToAdd = new Homework { Title = title, Description = description, DueDate = dueDate };

            _homeworkService.Add(homeworkToAdd);
        }
    }
}
