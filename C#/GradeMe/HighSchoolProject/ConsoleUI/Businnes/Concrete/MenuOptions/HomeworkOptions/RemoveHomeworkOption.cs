using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities;
using ConsoleUI.Utilities.Helpers;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.HomeworkOptions
{
    public class RemoveHomeworkOption : IMenuOption
    {
        IHomeworkService _homeworkService;

        public RemoveHomeworkOption(IHomeworkService homeworkService)
        {
            _homeworkService = homeworkService;
        }
        public void Execute()
        {
            var homeworks = _homeworkService.GetAll();

            var homework = NavigationLibrary.GetSelectedListItem("Silinecek ödevi [green]seçiniz[/]:", 20, homeworks);

            _homeworkService.Delete(homework.Id);
        }
    }
}
