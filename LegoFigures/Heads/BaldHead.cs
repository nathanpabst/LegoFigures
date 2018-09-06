using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Heads
{
    class BaldHead : Head
    {
        private readonly string _name;

        public override bool HasHair { get { return false; } }
        public int SmoothnessLevel { get; set; }

        public BaldHead(string name)
        {
            _name = name;
        }

        public override void Talk()
        {
            Console.WriteLine($"Hi, my name is {_name}.");
            base.Talk();
        }

        public override void Eat()
        {
            Console.WriteLine($"*{_name} eats a burrito*");
        }
    }
}
