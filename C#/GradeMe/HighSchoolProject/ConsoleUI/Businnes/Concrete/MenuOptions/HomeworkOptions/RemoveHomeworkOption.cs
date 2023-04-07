using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
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
            int homeworkId = ConsoleHelper.ReadIntWithText(PromptMessages.EnterHomeworkIdToDelete);
            Homework homeworkToRemove = _homeworkService.GetById(homeworkId);
            _homeworkService.Delete(homeworkToRemove);
        }
    }
}
