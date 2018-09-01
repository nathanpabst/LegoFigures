using LegoFigures.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures
{
    class MiniFigure
    {
        private readonly HeadBase _head;

        public MiniFigure(HeadBase head)
        {
            _head = head;
        }

        public void DoStuff()
        {
            _head.Talk();
            _head.Eat();
        }


    }
}
