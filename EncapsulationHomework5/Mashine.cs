using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationHomework5
{
    public abstract class Mashine : Object
    {
        public bool HasBattery => true;

        protected Mashine( string name, double speed, int intelligence)
            : base(name, speed, intelligence)
        {
        }
    }
}
