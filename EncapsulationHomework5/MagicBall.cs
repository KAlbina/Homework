using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationHomework5
{
    public class MagicBall : Object, IFlyable
    {
        public MagicBall( string name, double speed, int intelligence)
          : base(name, speed, intelligence)
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} летит с помощью магии.");
        }
    }
}
