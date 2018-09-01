using System;
using LegoFigures.Attributes;

namespace LegoFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var arms = new Arms("yellow");
            arms.KarateChop();

            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        }
    }
}
