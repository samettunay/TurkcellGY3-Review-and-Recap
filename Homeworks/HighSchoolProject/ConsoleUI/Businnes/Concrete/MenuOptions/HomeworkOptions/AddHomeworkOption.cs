using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Utilities.Helpers;
using ConsoleUI.Models;
using ConsoleUI.StaticData;

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
            string title = SpectreConsoleHelper.ReadLineWithText("Ödevin başlığını giriniz: ");
            string description = SpectreConsoleHelper.ReadLineWithText("Ödevin açıklamasını giriniz: ");
            DateTime dueDate = SpectreConsoleHelper.ReadDateTimeWithText("Ödevin son teslim tarihini giriniz: ");

            Homework homeworkToAdd = new Homework { Id = Guid.NewGuid(), Title = title, Description = description, DueDate = dueDate };

            _homeworkService.Add(homeworkToAdd);
        }
    }
}
