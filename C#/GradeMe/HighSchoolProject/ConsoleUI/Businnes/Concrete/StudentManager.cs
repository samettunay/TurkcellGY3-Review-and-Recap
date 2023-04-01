using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
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
        List<Student> _students;

        public StudentManager(List<Student> students)
        {
            _students = students;
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
    }
}
