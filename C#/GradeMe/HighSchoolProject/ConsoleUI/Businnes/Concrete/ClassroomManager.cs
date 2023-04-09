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
    public class ClassroomManager : IClassroomService
    {
        private readonly List<Classroom> _classrooms;
        IValidator<Classroom> _validator;
        public ClassroomManager(IValidator<Classroom> validator)
        {
            _classrooms = TestDataProvider.GetClassrooms();
            _validator = validator;
        }

        public void Add(Classroom classroom)
        {

            classroom = SetClassroomNumber(classroom);

            var validationResult = _validator.Validate(classroom);

            if (validationResult.IsValid)
            {
                _classrooms.Add(classroom);
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
            Classroom classroomToDelete = _classrooms.SingleOrDefault(c => c.Id == id);
            _classrooms.Remove(classroomToDelete);
            SpectreConsoleHelper.WriteLineWithColor("Başarıyla silindi.", "green");
        }

        public List<Classroom> GetAll()
        {
            return _classrooms;
        }

        public Classroom GetByClassNumber(int classNumber)
        {
            return _classrooms.FirstOrDefault(c => c.ClassNumber == classNumber);
        }

        public Classroom GetById(Guid id)
        {
            return _classrooms.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Classroom classroom)
        {
            var validationResult = _validator.Validate(classroom);
            if (validationResult.IsValid)
            {
                var classroomToUpdate = _classrooms.SingleOrDefault(c => c.Id == classroom.Id);
                classroomToUpdate.ResponsibleTeacher = classroom.ResponsibleTeacher;
                classroomToUpdate.Students = classroom.Students;
                classroomToUpdate.ClassNumber = classroom.ClassNumber;
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

        public void AddStudentInClassroom(Classroom classroom, Student student)
        {
            var result = CheckIfSameStudentInClassroom(classroom, student);
            if (result)
            {
                SpectreConsoleHelper.WriteLineWithColor("Öğrenci zaten sınıfta mevcut!", "red");
            }
            else
            {
                classroom.Students.Add(student);
                SpectreConsoleHelper.WriteLineWithColor("Öğrenci Başarıyla Eklendi.", "green");
            }
        }

        private bool CheckIfSameStudentInClassroom(Classroom classroom, Student student)
        {
            return classroom.Students.Any(s => s == student);
        }

        private Classroom SetClassroomNumber(Classroom classroom)
        {
            if (_classrooms.Any())
            {
                classroom.ClassNumber = _classrooms.Max(c => c.ClassNumber) + 1;
            }
            else
            {
                classroom.ClassNumber = 100;
            }
            return classroom;
        }
    }
}
