using LegoFigures.Heads;
using LegoFigures.Legs;
using LegoFigures.Torsos;
using System;

namespace LegoFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new HairyHead();
            var reptileBody = new ReptilianTorso();
            reptileBody.Color = "Brown";
            var babyLegs = new BabyLegs();
            babyLegs.Length = 19;
            babyLegs.MainColor = "purple";
            babyLegs.ShoeColor = "yellow";

            var bestTeacher = new MiniFigure("Nathan", head, reptileBody, babyLegs);

            bestTeacher.Greet();
            babyLegs.Walk();

            var head2 = new MartinHead();
            var birdBody = new BirdTorso();
            birdBody.Color = "pink";
            var manLegs = new Legs.Legs();
            manLegs.Length = 10;
            manLegs.MainColor = "blue";
            manLegs.ShoeColor = "brown";

            var martin = new MiniFigure("Martin", head2, birdBody, manLegs);

            martin.Greet();
            manLegs.Walk();

            bestTeacher.Karate(martin);

            martin.TakeABreak();
            bestTeacher.TakeABreak();

            Console.ReadLine();
        }
    }
}
