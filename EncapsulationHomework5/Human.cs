using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationHomework5
{
    public class Human : Creature, ILegged, ISwimmable, ISpeakable
    {
        public int LegsCount { get; set; } = 2;

        public Human(string name, double speed, int intelligence)
       : base(name, speed, intelligence)
        {
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} говорит");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} говорит");
        }
    }
}
