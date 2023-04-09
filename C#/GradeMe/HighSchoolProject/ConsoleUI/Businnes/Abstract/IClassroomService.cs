using ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Abstract
{
    public interface IClassroomService : IService<Classroom>
    {
        Classroom GetByClassNumber(int classNumber);
        void AddStudentInClassroom(Classroom classroom, Student student);
    }
}
