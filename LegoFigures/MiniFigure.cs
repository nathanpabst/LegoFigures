using LegoFigures.Heads;
using LegoFigures.Legs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures
{
    class MiniFigure
    {
        private readonly HeadBase _head;
        private readonly LegBase _legs;

        public MiniFigure(HeadBase head)
        {
            _head = head;
        }

        public MiniFigure(LegBase legs)
        {
            _legs = legs;
        }
        public void DoStuff()
        {
            _head.Talk();
            _head.Eat();
            _legs.KarateKick();
            _legs.RunAway();
        }


    }
}
