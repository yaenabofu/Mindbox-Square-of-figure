using SquareFigureLib;
using System;

namespace ConsoleTestingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2);
            Console.WriteLine(typeof(Circle).Name.ToString() + " square : " + circle.GetSquare());

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(typeof(Triangle).Name.ToString() + " square : " + triangle.GetSquare());
        }
    }
}
