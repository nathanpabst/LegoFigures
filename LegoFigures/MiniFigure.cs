using LegoFigures.Heads;
using LegoFigures.Torsos;
using LegoFigures.Legs;
using System;

namespace LegoFigures
{
    class MiniFigure
    {
        private readonly Head _head;
        private readonly Torso _torso;
        private readonly Legs.Legs _legs;

        public string Name { get; }
        public string Description
        {
            get
            {
                return $"{(_head.HasHair ? "Hairy" : "Bald" )} {_torso.Color} {_torso.NumberOfArms} armed thing";
            } 
        }

        public MiniFigure(string name, Head head, Torso torso, Legs.Legs legs)
        {
            Name = name;
            _head = head;
            _torso = torso;
            _legs = legs;
        }

        public void Karate(MiniFigure target)
        {
            _legs.Kick(target);
        }

        public void Greet()
        {
            _head.Talk();
            _torso.Wave();
           
        }

        public void TakeABreak()
        {
            _head.Eat();
            
            switch (_torso)
            {
                case BirdTorso bird :
                    bird.Fly();
                    bird.Dance();
                    break;
                case ReptilianTorso reptile :
                    reptile.Dance();
                    reptile.Twist();
                    break;
                case Torso boringTorso :
                    Console.WriteLine($"The boring torso was {boringTorso.Color} and has {boringTorso.NumberOfArms}");
                    break;
            }
        }


    }
}
