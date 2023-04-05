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
        ITeacherService _teacherService;
        IHomeworkService _homeworkService;
        IStudentService _studentService;
        public ClassroomManager(ITeacherService teacherService, IHomeworkService homeworkService, IStudentService studentService)
        {
            _classrooms = TestDataProvider.GetClassrooms();
            _teacherService = teacherService;
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

        public void WriteStudentsInClassRoom(int classId)
        {
            var classroom = GetById(classId);
            foreach (var student in classroom.Students)
            {
                AnsiConsole.WriteLine($"{classroom.ClassNumber}, {student.FirstName}, {student.LastName}, {student.StudentNumber}");
            }
        }

        public void AddHomeworkToAllStudentsInClassroom(int classId, int homeworkId)
        {
            var classroom = GetById(classId);
            var homework = _homeworkService.GetById(homeworkId);
            if (classroom == null)
            {
                throw new ArgumentException($"Classroom with Id {classId} not found");
            }

            if (classroom.Students == null)
            {
                return;
            }

            foreach (var student in classroom.Students)
            {
                if (student.Homeworks == null)
                {
                    student.Homeworks = new List<Homework>();
                }

                student.Homeworks.Add(homework);
            }
        }

        public void ManageClassrooms(string menu)
        {
            switch (menu)
            {
                case MenuOptions.GetClassrooms:
                    GetAll().ForEach(c => AnsiConsole.WriteLine($"{c.Id}, {c.ClassNumber}, sorumlu öğretmen: {c.ResponsibleTeacher?.FirstName}"));
                    break;
                case MenuOptions.AddClassroom:
                    int classroomCode = ConsoleHelper.ReadInt(PromptMessages.EnterClassroomCode);
                    int responsibleTeacherId = ConsoleHelper.ReadInt(PromptMessages.EnterClassroomResponsibleTeacherId);
                    Teacher responsibleTeacher = _teacherService.GetById(responsibleTeacherId);
                    Classroom classroom = new() { Id = 1, ClassNumber = classroomCode, ResponsibleTeacher = responsibleTeacher, Students = new() };
                    Add(classroom);
                    break;
                case MenuOptions.RemoveClassroom:
                    int classroomId = ConsoleHelper.ReadInt(PromptMessages.EnterClassroomIdToDelete);
                    Classroom classroomToDelete = GetById(classroomId);
                    Delete(classroomToDelete);
                    break;
                case MenuOptions.UpdateClassroom:
                    int id = ConsoleHelper.ReadInt(PromptMessages.EnterClassroomIdToUpdate);
                    classroomCode = ConsoleHelper.ReadInt(PromptMessages.EnterClassroomCode);
                    responsibleTeacherId = ConsoleHelper.ReadInt(PromptMessages.EnterClassroomResponsibleTeacherId);
                    responsibleTeacher = _teacherService.GetById(responsibleTeacherId);
                    Classroom classroomToUpdate = new() { Id = id, ClassNumber = classroomCode, ResponsibleTeacher = responsibleTeacher };
                    Update(classroomToUpdate);
                    break;
                case MenuOptions.AddHomeworkToAllStudentsInClass:
                    classroomCode = ConsoleHelper.ReadInt(PromptMessages.EnterClassroomCode);
                    int homeworkId = ConsoleHelper.ReadInt(PromptMessages.EnterHomeworkIdToAdd);
                    AddHomeworkToAllStudentsInClassroom(classroomCode, homeworkId);
                    break;
                case MenuOptions.AddStudentInClassroom:
                    classroomCode = ConsoleHelper.ReadInt(PromptMessages.EnterClassroomCode);
                    int studentId = ConsoleHelper.ReadInt(PromptMessages.EnterStudentIdToAdd);
                    AddStudentInClassroom(classroomCode, studentId);
                    break;
                case MenuOptions.GetStudentInClassroom:
                    classroomCode = ConsoleHelper.ReadInt(PromptMessages.EnterClassroomCode);
                    WriteStudentsInClassRoom(classroomCode);
                    break;
            }
        }
    }
}
