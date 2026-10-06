using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationHomework5
{
    public class Cat : Creature, ILegged, ISwimmable, ISpeakable
    {
        public int LegsCount { get; set; } = 4;

        public Cat(string name, double speed, int intelligence)
       : base(name, speed, intelligence)
        {
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} плывёт.");
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} мяукает.");
        }
    }
}
