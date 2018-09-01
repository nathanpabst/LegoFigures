using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Attributes
{
    class Torso
    {
        public string Color { get; set; }

        public Torso(string color) => Color = color;
        
        public void Crunches()
        {
            throw new NotImplementedException();
        }
    }
}
