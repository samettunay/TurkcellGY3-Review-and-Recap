﻿using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Utilities.Helpers
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
            AnsiConsole.Write(text);
            return int.Parse(Console.ReadLine());
        }

        public static void WriteLineWithColor(string text, string color)
        {
            AnsiConsole.MarkupLine($"[{color}]{text}[/]");
        }

        public static DateTime ReadDateTimeWithText(string text)
        {
            AnsiConsole.Write(text);
            return Convert.ToDateTime(Console.ReadLine());
        }

        public static bool ReadBooleanWithText(string text, string condition)
        {
            return text.Equals(condition);
        }
    }
}