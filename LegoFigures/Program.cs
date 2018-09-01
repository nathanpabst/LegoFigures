using System;
using LegoFigures.Heads;

namespace LegoFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new BaldHead();
            var figure = new MiniFigure(head);
            figure.DoStuff();



            Console.ReadLine();
        }
    }
}
