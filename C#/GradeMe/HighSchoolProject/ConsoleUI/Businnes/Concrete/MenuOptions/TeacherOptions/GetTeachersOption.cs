using ConsoleUI.Businnes.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.TeacherOptions
{
    public class GetTeachersOption : IMenuOption
    {
        ITeacherService _teacherService;

        public GetTeachersOption(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public void Execute()
        {
            _teacherService.GetAll().ForEach(t => Console.WriteLine($"{t.Id}, {t.FirstName}, {t.LastName}, {t.Department}"));
        }
    }
}
