using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    public static class GeometryLibrary
    {
        public static IAreaCalcutable RectangleFactory(double unit1, double? unit2 = null)
        {
            if (unit2.HasValue)
            {
                return new Rectangle() { Width = unit1, Height = unit2.Value };
            }
            else
            {
                return new Square() { EdgeLength = unit1 };
            }
        }
    }

    public interface IAreaCalcutable
    {
        double GetArea();
    }

    public class Rectangle : IAreaCalcutable
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : IAreaCalcutable
    {
        public double EdgeLength { get; set; }
        public double GetArea()
        {
            return EdgeLength * EdgeLength;
        }
    }
}
