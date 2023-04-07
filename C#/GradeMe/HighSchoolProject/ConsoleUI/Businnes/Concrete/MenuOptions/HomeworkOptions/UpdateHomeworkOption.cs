using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
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
            int homeworkId = ConsoleHelper.ReadIntWithText(PromptMessages.EnterHomeworkIdToUpdate);
            Homework homeworkToUpdate = _homeworkService.GetById(homeworkId);
            string title = ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkTitle);
            string description = ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkDescription);
            DateTime dueDate = ConsoleHelper.ReadDateTimeWithText(PromptMessages.EnterHomeworkDueDate);
            bool isComplete = ConsoleHelper.ReadBooleanWithText(PromptMessages.EnterHomeworkIsComplete, "Evet");
            int grade = ConsoleHelper.ReadIntWithText(PromptMessages.EnterHomeworkGrade);

            homeworkToUpdate.Title = title;
            homeworkToUpdate.Description = description;
            homeworkToUpdate.DueDate = dueDate;
            homeworkToUpdate.IsComplete = isComplete;
            homeworkToUpdate.Grade = grade;

            _homeworkService.Update(homeworkToUpdate);
        }
    }
}
