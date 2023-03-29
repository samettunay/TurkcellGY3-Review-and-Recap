using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static double GetSquare(this int value) => Math.Pow(value, 2);

        public static string MergeWords(this string value) => value.Replace(" ", "");
    }
}
