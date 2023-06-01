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
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly List<Student> _students;
        IValidator<Student> _validator;

        public StudentManager(IValidator<Student> validator)
        {
            _students = TestDataProvider.GetStudents();
            _validator = validator;
        }

        public void Add(Student student)
        {
            student = SetStudentNumber(student);

            var validationResult = _validator.Validate(student);
            if (validationResult.IsValid)
            {
                _students.Add(student);
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
            Student studentToDelete = _students.SingleOrDefault(s => s.Id == id);
            _students.Remove(studentToDelete);
            SpectreConsoleHelper.WriteLineWithColor("Başarıyla silindi.", "green");
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(Guid id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public Student GetByStudentNumber(int studentNumber)
        {
            return _students.FirstOrDefault(s => s.StudentNumber == studentNumber);
        }

        public void Update(Student student)
        {
            var validationResult = _validator.Validate(student);
            if (validationResult.IsValid)
            {
                var studentToUpdate = _students.SingleOrDefault(s => s.Id == student.Id);
                studentToUpdate.FirstName = student.FirstName;
                studentToUpdate.LastName = student.LastName;
                studentToUpdate.Homeworks = student.Homeworks;
                studentToUpdate.StudentNumber = student.StudentNumber;
                SpectreConsoleHelper.WriteLineWithColor("Başarıyla Güncellendi.", "green");
            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    SpectreConsoleHelper.WriteLineWithColor($"{error.PropertyName}: {error.ErrorMessage}", "red");
                }
            }
        }
        private Student SetStudentNumber(Student student)
        {
            if (_students.Any())
            {
                student.StudentNumber = _students.Max(s => s.StudentNumber) + 1;
            }
            else
            {
                student.StudentNumber = 100;
            }
            return student;
        }
    }
}
