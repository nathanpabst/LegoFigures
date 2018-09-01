using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Attributes
{
    class Head
    {
        public string Mood { get; set; }

        public Head(string mood) => Mood = mood;

        public void Joke()
        {
            throw new NotImplementedException();
        }

  
    }
}
