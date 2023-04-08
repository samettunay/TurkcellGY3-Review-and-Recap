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

        public void Add(Homework homework)
        {
            if (_homeworks.Any())
            {
                homework.Id = _homeworks.Max(h => h.Id) + 1;
            }
            else
            {
                homework.Id = 1;
            }

            _homeworks.Add(homework);
        }

        public void Delete(int id)
        {
            Homework homeworkToDelete = _homeworks.SingleOrDefault(h => h.Id == id);
            _homeworks.Remove(homeworkToDelete);
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
        }
    }
}
