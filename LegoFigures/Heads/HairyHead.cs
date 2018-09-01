using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Heads
{
    class HairyHead : HeadBase
    {
        public override bool HasHair => true;

        public string HairColor => "blonde";

        public string Texture { get; set; }

        public override void Eat()
        {
            Console.WriteLine("*eats a horse*");
        }

    }
}
