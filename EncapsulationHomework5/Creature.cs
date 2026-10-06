using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationHomework5
{
    public abstract class Creature : CompetitionParticipant
    {
        public bool HasBrain => true;
        protected Creature(string name, double speed, int intelligence)
        : base(name, speed, intelligence)
        {
        }

    }
}
