using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities.Helpers;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete
{
    public class HomeworkManager : IHomeworkService
    {
        List<Homework> _homeworks;

        public HomeworkManager()
        {
            _homeworks = TestDataProvider.GetHomeworks();
        }

        public void Add(Homework student)
        {
            _homeworks.Add(student);
        }

        public void Delete(Homework homework)
        {
            Homework homeworkToDelete = _homeworks.SingleOrDefault(h => h.Id == homework.Id);
            _homeworks.Remove(homework);
        }

        public List<Homework> GetAll()
        {
            return _homeworks;
        }

        public Homework GetById(int id)
        {
            return _homeworks.FirstOrDefault(h => h.Id == id);
        }

        public void Update(Homework homework)
        {
            var homeworkToUpdate = _homeworks.SingleOrDefault(h => h.Id == homework.Id);
            homeworkToUpdate.DueDate = homework.DueDate;
            homeworkToUpdate.Title = homework.Title;
            homeworkToUpdate.Description = homework.Description;
            homeworkToUpdate.IsComplete = homework.IsComplete;
        }
        public void ManageHomeworks(string menu)
        {
            if (menu.Equals(MenuOptions.GetHomeworks))
            {
                GetAll().ForEach(h => AnsiConsole.WriteLine($"{h.Id}, {h.Title}, {h.Description}, {h.DueDate}, {h.IsComplete}, {h.Grade}"));
            }
            else if (menu.Equals(MenuOptions.AddHomework))
            {
                string title = ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkTitle);
                string description = ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkDescription);
                DateTime dueDate = Convert.ToDateTime(ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkDueDate));
                bool isComplete = ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkIsComplete) == "Evet";
                int grade = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkGrade));

                Homework homework = new() { Id = 1, Title = title, Description = description, DueDate = dueDate, IsComplete = isComplete, Grade = grade };

                Add(homework);
            }
            else if (menu.Equals(MenuOptions.RemoveHomework))
            {
                int homeworkId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkIdToDelete));
                Homework homeworkToDelete = GetById(homeworkId);
                Delete(homeworkToDelete);
            }
            else if (menu.Equals(MenuOptions.UpdateHomework))
            {
                string title = ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkTitle);
                string description = ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkDescription);
                DateTime dueDate = Convert.ToDateTime(ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkDueDate));
                bool isComplete = ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkIsComplete) == "Evet";
                int grade = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterHomeworkGrade));

                Homework homeworkToUpdate = new() { Id = 1, Title = title, Description = description, DueDate = dueDate, IsComplete = isComplete, Grade = grade };

                Update(homeworkToUpdate);
            }
        }
    }
}
