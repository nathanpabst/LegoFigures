using System;

namespace LegoFigures.Heads
{
    abstract class Head
    {
        public abstract bool HasHair { get; }

        public virtual void Talk()
        {
            Console.WriteLine("Oh hey, hi. I'm talking. Cooooool.");
        }

        public abstract void Eat();

    }
}
