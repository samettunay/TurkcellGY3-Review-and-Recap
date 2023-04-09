using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Utilities.Helpers;
using ConsoleUI.Businnes.ValidationRules;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using FluentValidation;
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
        private readonly List<Homework> _homeworks;
        IValidator<Homework> _validator;
        public HomeworkManager(IValidator<Homework> validator)
        {
            _homeworks = TestDataProvider.GetHomeworks();
            _validator = validator;
        }

        public void Add(Homework homework)
        {
            var validationResult = _validator.Validate(homework);
            if (validationResult.IsValid)
            {
                _homeworks.Add(homework);
                SpectreConsoleHelper.WriteLineWithColor("Başarıyla eklendi.", "green");
            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    SpectreConsoleHelper.WriteLineWithColor($"{error.PropertyName}: {error.ErrorMessage}", "red");
                }
            }  
        }

        public void Delete(Guid id)
        {
            // Menüden listeden seçildiği için null olamaz
            Homework homeworkToDelete = _homeworks.SingleOrDefault(h => h.Id == id);
            _homeworks.Remove(homeworkToDelete);
            SpectreConsoleHelper.WriteLineWithColor("Başarıyla silindi.", "green");
        }

        public List<Homework> GetAll()
        {
            return _homeworks;
        }

        public Homework GetById(Guid id)
        {
            return _homeworks.FirstOrDefault(h => h.Id == id);
        }

        public void Update(Homework homework)
        {
            var validationResult = _validator.Validate(homework);
            if (validationResult.IsValid)
            {
                var homeworkToUpdate = _homeworks.SingleOrDefault(h => h.Id == homework.Id);
                homeworkToUpdate.DueDate = homework.DueDate;
                homeworkToUpdate.Title = homework.Title;
                homeworkToUpdate.Description = homework.Description;
                SpectreConsoleHelper.WriteLineWithColor("Başarıyla güncellendi.", "green");
            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    SpectreConsoleHelper.WriteLineWithColor($"{error.PropertyName}: {error.ErrorMessage}", "red");
                }
            }
        }
    }
}
