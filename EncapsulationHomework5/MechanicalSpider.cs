using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationHomework5
{
    public class MechanicalSpider : Mashine, ILegged
    {
        public int LegsCount { get; set; } = 4;
        public MechanicalSpider(string name, double speed, int intelligence)
       : base(name, speed, intelligence)
        {
        }

    }
}
