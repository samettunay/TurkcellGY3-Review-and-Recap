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
        public ClassroomManager(ITeacherService teacherService)
        {
            _classrooms = TestDataProvider.GetClassrooms();
            _teacherService = teacherService;
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
        public void ManageClassrooms(string menu)
        {
            if (menu.Equals(MenuOptions.GetClassrooms))
            {
                // TODO 01: Öğrencileri ve sorumlu öğretmeni listele
                GetAll().ForEach(c => AnsiConsole.WriteLine($"{c.Id}, {c.ClassNumber}, öğrenciler, sorumlu öğretmen: {c.ResponsibleTeacher?.FirstName}"));
            }
            else if (menu.Equals(MenuOptions.AddClassroom))
            {
                int classroomCode = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterClassroomCode));
                int responsibleTeacherId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterClassroomResponsibleTeacherId));
                Teacher responsibleTeacher = _teacherService.GetById(responsibleTeacherId);
                // TODO 02: Öğrencileri sınıfta listele

                Classroom classroom = new() { Id = 1, ClassNumber = classroomCode, ResponsibleTeacher = responsibleTeacher};

                Add(classroom);
            }
            else if (menu.Equals(MenuOptions.RemoveClassroom))
            {
                int classroomId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterClassroomIdToDelete));
                Classroom classroomToDelete = GetById(classroomId);
                Delete(classroomToDelete);
            }
            else if (menu.Equals(MenuOptions.UpdateClassroom))
            {
                int classroomId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterClassroomIdToUpdate));
                int classroomCode = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterClassroomCode));
                int responsibleTeacherId = int.Parse(ConsoleHelper.ReadLineWithText(PromptMessages.EnterClassroomResponsibleTeacherId));
                Teacher responsibleTeacher = _teacherService.GetById(responsibleTeacherId);

                Classroom classroomToUpdate = new() { Id = classroomId, ClassNumber = classroomCode, ResponsibleTeacher = responsibleTeacher };
                Update(classroomToUpdate);
            }
        }
    }
}
