using System;
using LegoFigures.Heads;
using LegoFigures.Legs;

namespace LegoFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new BaldHead();
            var figure = new MiniFigure(head);
            figure.DoStuff();

            var head2 = new HairyHead();
            var figure2 = new MiniFigure(head2);
            figure2.DoStuff();

            var angryLegs = new AngryLegs();
            var figure3 = new MiniFigure(angryLegs);
            figure3.DoStuff();



            Console.ReadLine();
        }
    }
}
