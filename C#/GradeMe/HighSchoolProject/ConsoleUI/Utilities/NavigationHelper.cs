using ConsoleUI.Enums;
using ConsoleUI.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Utilities
{
    public class NavigationHelper
    {
        public NavigationHelper(List<string> mainNavigation)
        {
            Navigate(mainNavigation);
        }
        public void Navigate(List<string> navigation)
        {
            Console.Clear();
            for (int i = 0; i < navigation.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {navigation[i]}");
            }
        }
        public void StartNavigation(List<Action> actions)
        {
            Console.Write("Bir işlem seçiniz: ");
            int choice = int.Parse(Console.ReadLine());
            NavigationEnum navigationChoice = (NavigationEnum)choice;

            switch (navigationChoice)
            {
                case NavigationEnum.ClassroomNav:
                    actions[(int)NavigationEnum.ClassroomNav]();
                    break;
                case NavigationEnum.TeacherNav:
                    actions[(int)NavigationEnum.TeacherNav]();
                    break;
                case NavigationEnum.StudentNav:
                    actions[(int)NavigationEnum.StudentNav]();
                    break;
                case NavigationEnum.HomeworkNav:
                    actions[(int)NavigationEnum.HomeworkNav]();
                    break;
                case NavigationEnum.Exit:
                    Console.WriteLine("Programdan çıkılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçenek, lütfen tekrar deneyin.");
                    break;
            }
        }
    }
}
