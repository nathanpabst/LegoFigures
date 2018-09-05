using LegoFigures.Heads;
//using LegoFigures.Legs;
using System;
using LegoFigures.Torsos;

namespace LegoFigures
{
    class MiniFigure
    {
        private readonly HeadBase _head;
        private readonly LegBase _legs;
        private readonly Torso _torso;

        public MiniFigure(HeadBase head, Torso torso)
        {
            _head = head;
            _torso = torso;
        }

        //public MiniFigure(LegBase legs)
        //{
        //    _legs = legs;
        //}

        public void Greet()
        {
            _head.Talk();
           
        }

        public void TakeABreak()
        {
            _head.Eat();
            
            switch (_torso)
            {
                case BirdTorso bird :
                    bird.Fly();
                    bird.Dance();
                    bird.Fly();
                    break;
                case ReptilianTorso reptile :
                    reptile.Dance();
                    break;
                case Torso boringTorso :
                    Console.WriteLine($"The boring torso was {boringTorso.Color} and has {boringTorso.NumberOfArms}");
                    break;
            }
        }


    }
}
