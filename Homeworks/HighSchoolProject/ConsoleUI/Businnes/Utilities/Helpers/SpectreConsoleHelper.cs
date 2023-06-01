using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Businnes.Utilities.Helpers
{
    public static class SpectreConsoleHelper
    {
        public static string ReadLineWithText(string text)
        {
            AnsiConsole.Write(text);
            return Console.ReadLine();
        }

        public static int ReadIntWithText(string text)
        {
            while (true) // Tekrar input istemek için
            {
                try
                {
                    AnsiConsole.Write(text);
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    WriteLineWithColor("Tam sayı formatı yanlış!", "red");
                }
            }
        }

        public static void WriteLineWithColor(string text, string color)
        {
            AnsiConsole.MarkupLine($"[{color}]{text}[/]");
        }

        public static DateTime ReadDateTimeWithText(string text)
        {
            while (true) // Tekrar input istemek için
            {
                try
                {
                    AnsiConsole.Write(text);
                    return Convert.ToDateTime(Console.ReadLine());

                }
                catch (FormatException e)
                {
                    WriteLineWithColor("Tarih formatı yanlış! dd/mm/yy yada dd.mm.yy", "red");
                }
            }
        }

        public static bool ReadBooleanWithText(string text, string condition)
        {
            return text.Equals(condition);
        }
    }
}
