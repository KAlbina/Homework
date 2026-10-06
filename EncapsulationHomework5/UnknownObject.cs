using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationHomework5
{
    public abstract class UnknownObject : Object
    {
        public UnknownObject(
            string name,
            double speed,
            int intelligence)
            : base(name, speed, intelligence)
        {
        }
    }
}
