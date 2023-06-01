using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Utilities;
using ConsoleUI.Businnes.Utilities.Helpers;
using ConsoleUI.Models;
using ConsoleUI.StaticData;

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


            string title = SpectreConsoleHelper.ReadLineWithText("Ödevin başlığını giriniz: ");
            string description = SpectreConsoleHelper.ReadLineWithText("Ödevin açıklamasını giriniz: ");
            DateTime dueDate = SpectreConsoleHelper.ReadDateTimeWithText("Ödevin son teslim tarihini giriniz: ");

            Homework homeworkToUpdate = new Homework();
            homeworkToUpdate.Id = homework.Id;
            homeworkToUpdate.Title = title;
            homeworkToUpdate.Description = description;
            homeworkToUpdate.DueDate = dueDate;

            _homeworkService.Update(homeworkToUpdate);
        }
    }
}
