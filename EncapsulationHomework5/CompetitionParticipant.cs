using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationHomework5
{
    public abstract class CompetitionParticipant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Speed {  get; set; }
        public int Intelligence { get; set; }

        protected CompetitionParticipant(string name, double speed, int intelligence)
        {
            Id = Guid.NewGuid();
            Name = name;
            Speed = speed;
            Intelligence = intelligence;
        }

    }
}
