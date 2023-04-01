using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
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

        public HomeworkManager(List<Homework> homeworks)
        {
            _homeworks = homeworks;
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
    }
}
