using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Utilities.Helpers
{
    public static class ConsoleHelper
    {
        public static string ReadLineWithText(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }

        public static int ReadInt(string text)
        {
            Console.Write(text);
            return int.Parse(Console.ReadLine());
        }
    }
}
