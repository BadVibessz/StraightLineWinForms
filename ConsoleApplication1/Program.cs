using System;
using StraightLineLibrary;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var line = new StraightLine(new Point(-2, 3, -1), new Vector(1, 3, 2));
            var plane = new Plane(0, 2, -1, -11);

            var p = StraightLine.Intersect(line, plane);

            Console.WriteLine(p.X + " " + p.Y + " " + p.Z);
        }
    }
}