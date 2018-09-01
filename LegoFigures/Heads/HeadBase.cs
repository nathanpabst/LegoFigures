using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Heads
{
    abstract class HeadBase
    {
        public abstract bool HasHair { get; }

        public virtual void Talk()
        {
            Console.WriteLine("Oh hey, hi. I'm talking. Cooooool.");
        }

        public abstract void Eat();
        
    }
}
