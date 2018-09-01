using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Attributes
{
    class Legs
    {
        public string Color { get; set; }

        public Legs(string color) => Color = color;

        public void Jump()
        {
            throw new NotImplementedException();
        }
    }
}
