using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Torsos
{
    class ReptilianTorso : Torso
    {
        public string ScaleShape { get; set; }

        public void Dance()
        {
            Console.WriteLine($"*Breakdances vigorously in {Color}*");
        }

        public void Twist()
        {
            Console.WriteLine("*does the twist and sings and a little bit louder now.*");
        }
    }
}
