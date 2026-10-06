using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationHomework5
{
    public abstract class Object : CompetitionParticipant
    {
        protected Object(
       string name,
       double speed,
       int intelligence)
       : base(name, speed, intelligence)
        {
        }
    }
}
