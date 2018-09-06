using System;

namespace LegoFigures.Torsos
{
    class Torso
    {
        public string Color { get; set; }
        public int NumberOfArms { get; set; } = 1;
        public bool HasClothes { get; set; }

        public void Wave()
        {
            if (NumberOfArms >= 1)
            {
                Console.WriteLine("*waves*");
            }
        }
    }
}
