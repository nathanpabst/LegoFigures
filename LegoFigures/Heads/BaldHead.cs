using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Heads
{
    class BaldHead : HeadBase
    {
        public override bool HasHair { get { return false; } }

        public int SmoothnessLevel { get; set; }

        public override void Talk()
        {
            Console.WriteLine("Hi, my name is Nathan.");
        }

        public override void Eat()
        {
            Console.WriteLine("*eats a burrito*");
        }
    }
}
