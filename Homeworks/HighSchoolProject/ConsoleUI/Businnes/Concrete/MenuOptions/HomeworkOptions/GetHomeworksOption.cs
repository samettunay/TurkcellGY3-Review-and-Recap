using ConsoleUI.Businnes.Abstract;
using Microsoft.VisualBasic;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Concrete.MenuOptions.HomeworkOptions
{
    public class GetHomeworksOption : IMenuOption
    {
        IHomeworkService _homeworkService;

        public GetHomeworksOption(IHomeworkService homeworkService)
        {
            _homeworkService = homeworkService;
        }

        public void Execute()
        {
            var allHomeworks = _homeworkService.GetAll();

            foreach (var homework in allHomeworks)
            {
                AnsiConsole.MarkupLine($"[red]Başlık:[/] {homework.Title} [red]Açıklama:[/] {homework.Description} [red]Son Teslim:[/] {homework.DueDate}");
            }
        }
    }
}
