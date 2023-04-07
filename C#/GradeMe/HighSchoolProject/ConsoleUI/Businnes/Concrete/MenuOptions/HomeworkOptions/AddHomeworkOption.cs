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
            string title = ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkTitle);
            string description = ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkDescription);
            DateTime dueDate = ConsoleHelper.ReadDateTimeWithText(PromptMessages.EnterHomeworkDueDate);
            bool isComplete = ConsoleHelper.ReadBooleanWithText(PromptMessages.EnterHomeworkIsComplete, "Evet");
            int grade = ConsoleHelper.ReadIntWithText(PromptMessages.EnterHomeworkGrade);

            Homework homeworkToAdd = new Homework { Title = title, Description = description, DueDate = dueDate, IsComplete = isComplete, Grade = grade };

            _homeworkService.Add(homeworkToAdd);
        }
    }
}
