using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationHomework5
{
    public class Drone : Mashine, IFlyable
    {
        public Drone(string name, double speed, int intelligence)
        : base(name, speed, intelligence)
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} летит.");
        }
    }
}
