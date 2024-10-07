using System;
using NonPremitives.Math;

namespace NonPremitives
{
    public struct RGBColor
    {
        public int Red;
        public int Green;
        public int Blue;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();

            john.FirstName = "John";
            john.LastName = "Smith";

            john.Introduce();

            var calculator = new Calculator();
            // System.Console.WriteLine(calculator.Add(10, 20));

            var rgb = new RGBColor();
            // System.Console.WriteLine(rgb.Red);
            // System.Console.WriteLine(rgb.Green);
            // System.Console.WriteLine(rgb.Blue);

            // Array.init();

            // Strings.init();

            // Enums.init();
        }
    }
}
