using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete
{
    public class ClassroomManager : IClassroomService
    {
        List<Classroom> _classrooms;

        public ClassroomManager(List<Classroom> classroom)
        {
            _classrooms = classroom;
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
    }
}
