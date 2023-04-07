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
    public class ClassroomManager : IClassroomService
    {
        private readonly List<Classroom> _classrooms;
        IHomeworkService _homeworkService;
        IStudentService _studentService;
        public ClassroomManager(IHomeworkService homeworkService, IStudentService studentService)
        {
            _classrooms = TestDataProvider.GetClassrooms();
            _homeworkService = homeworkService;
            _studentService = studentService;
        }

        public void Add(Classroom classroom)
        {
            _classrooms.Add(classroom);
        }

        public void Delete(Classroom classroom)
        {
            Classroom classroomToDelete = _classrooms.SingleOrDefault(c => c.Id == classroom.Id);
            _classrooms.Remove(classroomToDelete);
        }

        public List<Classroom> GetAll()
        {
            return _classrooms;
        }

        public Classroom GetByClassNumber(int classNumber)
        {
            return _classrooms.FirstOrDefault(c => c.ClassNumber == classNumber);
        }

        public Classroom GetById(int id)
        {
            return _classrooms.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Classroom classroom)
        {
            var classroomToUpdate = _classrooms.SingleOrDefault(c => c.Id == classroom.Id);
            classroomToUpdate.ResponsibleTeacher = classroom.ResponsibleTeacher;
            classroomToUpdate.Students = classroom.Students;
            classroomToUpdate.ClassNumber = classroom.ClassNumber;
        }

        public void AddStudentInClassroom(int classId, int studentId)
        {
            var classroom = GetById(classId);
            var student = _studentService.GetById(studentId);
            classroom.Students.Add(student);
        }

        public void AddHomeworkToAllStudentsInClassroom(int classId, int homeworkId)
        {
            var classroom = GetById(classId);
            var homework = _homeworkService.GetById(homeworkId);

            foreach (var student in classroom.Students)
            {
                if (student.Homeworks == null)
                {
                    student.Homeworks = new List<Homework>();
                }

                student.Homeworks.Add(homework);
            }
        }
    }
}
