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

            var legs = new Legs("green");
            legs.Jump();

            var head = new Head("happy");
            head.Joke();

            var hair = new Hair("blue");
            hair.Flames();

            var torso = new Torso("red");
            torso.Crunches();

            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        }
    }
}
