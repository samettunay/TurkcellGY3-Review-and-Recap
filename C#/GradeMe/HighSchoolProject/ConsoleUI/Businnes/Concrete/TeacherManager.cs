using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Utilities.Helpers;
using ConsoleUI.Businnes.ValidationRules;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete
{
    public class TeacherManager : ITeacherService
    {
        IStudentService _studentService;
        IHomeworkService _homeworkService;
        IClassroomService _classroomService;

        private readonly List<Teacher> _teachers;
        public TeacherManager(IStudentService studentService, IHomeworkService homeworkService, IClassroomService classroomService)
        {
            _teachers = TestDataProvider.GetTeachers();
            _studentService = studentService;
            _homeworkService = homeworkService;
            _classroomService = classroomService;
        }

        public void Add(Teacher teacher)
        {
            var validator = new TeacherValidator();
            var validationResult = validator.Validate(teacher);
            if (validationResult.IsValid)
            {
                _teachers.Add(teacher);
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
            Teacher teacherToDelete = _teachers.SingleOrDefault(t => t.Id == id);
            _teachers.Remove(teacherToDelete);
            SpectreConsoleHelper.WriteLineWithColor("Başarıyla silindi.", "green");
        }

        public List<Teacher> GetAll()
        {
            return _teachers;
        }

        public Teacher GetById(Guid id)
        {
            return _teachers.FirstOrDefault(t => t.Id == id);
        }

        public void Update(Teacher teacher)
        {
            var validator = new TeacherValidator();
            var validationResult = validator.Validate(teacher);
            if (validationResult.IsValid)
            {
                var teacherToUpdate = _teachers.SingleOrDefault(t => t.Id == teacher.Id);
                teacherToUpdate.FirstName = teacher.FirstName;
                teacherToUpdate.LastName = teacher.LastName;
                teacherToUpdate.Department = teacher.Department;
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
        public void AddHomeworkToStudent(Guid studentId, Guid homeworkId)
        {
            var student = _studentService.GetById(studentId);
            var homework = _homeworkService.GetById(homeworkId);

            if (student.Homeworks == null)
            {
                student.Homeworks = new List<Homework>();
            }

            student.Homeworks.Add(homework);
            SpectreConsoleHelper.WriteLineWithColor("Ödev başarıyla eklendi.", "green");
        }
        public void AddHomeworkToAllStudentsInClassroom(Guid classId, Guid homeworkId)
        {
            var classroom = _classroomService.GetById(classId);
            var homework = _homeworkService.GetById(homeworkId);

            var rule = CheckIfHaveStudentInClassroom(classroom);

            if (rule)
            {
                foreach (var student in classroom.Students)
                {
                    if (student.Homeworks == null)
                    {
                        student.Homeworks = new List<Homework>();
                    }

                    student.Homeworks.Add(homework);
                }
                SpectreConsoleHelper.WriteLineWithColor($"{classroom.ClassNumber} Numaralı sınıfa ödev başarıyla eklendi.", "green");
            }
            else
            {
                SpectreConsoleHelper.WriteLineWithColor($"Sınıfta öğrenci bunulmuyor.", "red");
            }

        }
        public List<Homework> GetHomeworksSelectedStudent(Student student)
        {
            var selectedStudent = _studentService.GetById(student.Id);
            var rule = CheckIfHaveHomeworkOfStudent(selectedStudent);
            if (rule)
            {
                return selectedStudent.Homeworks;
            }
            else
            {
                SpectreConsoleHelper.WriteLineWithColor($"Öğrencinin ödevi bunulmuyor.", "red");
                return null;
            }
        }

        private bool CheckIfHaveHomeworkOfStudent(Student student)
        {
            return student.Homeworks != null;
        }

        private bool CheckIfHaveStudentInClassroom(Classroom classroom)
        {
            return classroom.Students.Count != 0;
        }
    }
}
