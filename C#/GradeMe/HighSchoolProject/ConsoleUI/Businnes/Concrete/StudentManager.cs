using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities.Helpers;
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

        public StudentManager()
        {
            _students = TestDataProvider.GetStudents();
        }

        public void Add(Student student)
        {
            _students.Add(student);
        }

        public void Delete(Student student)
        {
            Student studentToDelete = _students.SingleOrDefault(s => s.Id == student.Id);
            _students.Remove(student);
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public Student GetByStudentNumber(int studentNumber)
        {
            return _students.FirstOrDefault(s => s.StudentNumber == studentNumber);
        }

        public void Update(Student student)
        {
            var studentToUpdate = _students.SingleOrDefault(s => s.Id == student.Id);
            studentToUpdate.FirstName = student.FirstName;
            studentToUpdate.LastName = student.LastName;
            studentToUpdate.Homeworks = student.Homeworks;
            studentToUpdate.StudentNumber = student.StudentNumber;
        }

        public void ManageStudents(string menu)
        {
            if (menu.Equals(MenuOptions.GetStudents))
            {
                GetAll().ForEach(s => AnsiConsole.WriteLine($"{s.Id}, {s.StudentNumber}, {s.FirstName}, {s.LastName}"));
            }
            else if (menu.Equals(MenuOptions.AddStudent))
            {
                string firstName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentName);
                string lastName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentLastName);
                int studentNumber = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentNumber));

                Student student = new() { Id = 1, FirstName = firstName, LastName = lastName, StudentNumber = studentNumber };

                Add(student);
            }
            else if (menu.Equals(MenuOptions.RemoveStudent))
            {
                int studentId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentIdToDelete));
                Student studentToDelete = GetById(studentId);
                Delete(studentToDelete);
            }
            else if (menu.Equals(MenuOptions.UpdateStudent))
            {
                int studentId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentIdToUpdate));
                string firstName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentName);
                string lastName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentLastName);
                int studentNumber = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterStudentNumber));
                Student studentToUpdate = new() { Id = studentId, FirstName = firstName, LastName = lastName, StudentNumber = studentNumber };
                Update(studentToUpdate);
            }
        }
    }
}
