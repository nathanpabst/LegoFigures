using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Attributes
{
    class Arms
    {
        public string Color { get; set; }

        public Arms(string color) => Color = color;

        public void KarateChop()
        {
            throw new NotImplementedException();
        }
    }
}
