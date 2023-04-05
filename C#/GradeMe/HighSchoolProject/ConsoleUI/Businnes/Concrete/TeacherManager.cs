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
    public class TeacherManager : ITeacherService
    {
        private readonly List<Teacher> _teachers;
        public TeacherManager()
        {
            _teachers = TestDataProvider.GetTeachers();
        }

        public void Add(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void Delete(Teacher teacher)
        {
            Teacher teacherToDelete = _teachers.SingleOrDefault(t => t.Id == teacher.Id);
            _teachers.Remove(teacher);
        }

        public List<Teacher> GetAll()
        {
            return _teachers;
        }

        public Teacher GetById(int id)
        {
            return _teachers.FirstOrDefault(t => t.Id == id);
        }

        public void Update(Teacher teacher)
        {
            var teacherToUpdate = _teachers.SingleOrDefault(t => t.Id == teacher.Id);
            teacherToUpdate.FirstName = teacher.FirstName;
            teacherToUpdate.LastName = teacher.LastName;
            teacherToUpdate.Department = teacher.Department;
        }

        public void ManageTeachers(string menu)
        {
            if (menu.Equals(MenuOptions.GetTeachers))
            {
                GetAll().ForEach(t => AnsiConsole.WriteLine($"{t.Id}, {t.FirstName}, {t.LastName}, {t.Department}"));
            }
            else if (menu.Equals(MenuOptions.AddTeacher))
            {
                string firstName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherName);
                string lastName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherLastName);
                string department = ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherDepartment);

                Teacher teacher = new() { Id = 1, FirstName = firstName, LastName = lastName, Department = department };

                Add(teacher);
            }
            else if (menu.Equals(MenuOptions.RemoveTeacher))
            {
                int teacherId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherIdToDelete));
                Teacher teacherToDelete = GetById(teacherId);
                Delete(teacherToDelete);
            }
            else if (menu.Equals(MenuOptions.UpdateTeacher))
            {
                int teacherId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherIdToUpdate));
                string firstName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherName);
                string lastName = ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherLastName);
                string department = ConsoleHelper.ReadLineWithText(PromptMessages.EnterTeacherDepartment);
                Teacher teacherToUpdate = new() { Id = teacherId, FirstName = firstName, LastName = lastName, Department = department };
                Update(teacherToUpdate);
            }
        }
    }
}
