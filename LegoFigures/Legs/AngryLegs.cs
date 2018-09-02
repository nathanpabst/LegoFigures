using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Legs
{
    class AngryLegs : LegBase
    {
        public override bool IsMean => true;

        public int NicenessLevel { get; set; }

        public override void KarateKick()
        {
            Console.WriteLine("*angry lego man karate kicks you in the eardrum*");
        }

        public override void RunAway()
        {
            Console.WriteLine("*angry lego man runs away...*");
        }
    }
}
