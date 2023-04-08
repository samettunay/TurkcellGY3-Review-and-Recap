using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities;
using ConsoleUI.Utilities.Helpers;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.HomeworkOptions
{
    public class UpdateHomeworkOption : IMenuOption
    {
        IHomeworkService _homeworkService;

        public UpdateHomeworkOption(IHomeworkService homeworkService)
        {
            _homeworkService = homeworkService;
        }

        public void Execute()
        {
            var homeworks = _homeworkService.GetAll();

            var homework = NavigationLibrary.GetSelectedListItem("Güncellenecek ödevi [green]seçiniz[/]:", 20, homeworks);


            string title = SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkTitle);
            string description = SpectreConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkDescription);
            DateTime dueDate = SpectreConsoleHelper.ReadDateTimeWithText(PromptMessages.EnterHomeworkDueDate);

            Homework homeworkToUpdate = new Homework();
            homeworkToUpdate.Id = homework.Id;
            homeworkToUpdate.Title = title;
            homeworkToUpdate.Description = description;
            homeworkToUpdate.DueDate = dueDate;

            _homeworkService.Update(homeworkToUpdate);
        }
    }
}
