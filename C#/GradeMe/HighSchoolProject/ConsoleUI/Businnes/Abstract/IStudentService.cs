using ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Abstract
{
    public interface IStudentService : IService<Student>
    {
        Student GetByStudentNumber(int studentNumber);
        List<Homework> GetStudentHomeworks(Guid studentId);
    }
}
