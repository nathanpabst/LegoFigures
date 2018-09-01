using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Attributes
{
    class Hair
    {
        public string Color { get; set; }

        public Hair(string color) => Color = color;

        public void Flames()
        {
            throw new NotImplementedException();
        }
    }
}
