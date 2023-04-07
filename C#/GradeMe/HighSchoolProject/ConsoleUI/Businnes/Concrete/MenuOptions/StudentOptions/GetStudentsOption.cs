using ConsoleUI.Businnes.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.StudentOptions
{
    public class GetStudentsOption : IMenuOption
    {
        IStudentService _studentService;

        public GetStudentsOption(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void Execute()
        {
            _studentService.GetAll().ForEach(s => Console.WriteLine($"{s.Id}, {s.StudentNumber}, {s.FirstName}, {s.LastName}"));
        }
    }
}
