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
            if (_teachers.Any())
            {
                teacher.Id = _teachers.Max(t => t.Id) + 1;
            }
            else
            {
                teacher.Id = 1;
            }
            _teachers.Add(teacher);
        }


        public void Delete(int id)
        {
            Teacher teacherToDelete = _teachers.SingleOrDefault(t => t.Id == id);
            _teachers.Remove(teacherToDelete);
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
        public void AddHomeworkToStudent(int studentId, int homeworkId)
        {
            var student = _studentService.GetById(studentId);
            var homework = _homeworkService.GetById(homeworkId);

            if (student.Homeworks == null)
            {
                student.Homeworks = new List<Homework>();
            }

            student.Homeworks.Add(homework);
        }
        public void AddHomeworkToAllStudentsInClassroom(int classId, int homeworkId)
        {
            var classroom = _classroomService.GetById(classId);
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
        public List<Homework> GetHomeworksSelectedStudent(Student student)
        {
            var selectedStudent = _studentService.GetById(student.Id);

            return selectedStudent.Homeworks;
        }
    }
}
