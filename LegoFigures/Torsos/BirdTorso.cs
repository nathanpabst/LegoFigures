﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Torsos
{
    class BirdTorso : ReptilianTorso
    {
        
        public bool CanFly { get; set; }

        public void Fly()
        {
            if (CanFly)
            {
                Console.WriteLine("I believe I can fly...");
            }
            else
            {
                Console.WriteLine("I am a grounded bird.");
            }
        }
        class Torso
        {
            public string Color { get; set; }


        }
    }

}
