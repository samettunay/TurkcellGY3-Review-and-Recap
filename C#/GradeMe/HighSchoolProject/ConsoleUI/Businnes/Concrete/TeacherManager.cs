using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete
{
    public class TeacherManager : ITeacherService
    {
        List<Teacher> _teachers;

        public TeacherManager(List<Teacher> teachers)
        {
            _teachers = teachers;
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
    }
}
