using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        private Random volition { get; set; }
        public int Hit { get; set; }
        public int Multiplier { get; set; }

        public Dart(Random willOfTheFates)
        {
            this.volition = willOfTheFates;
        }

        public void Throw()
        {
            this.Multiplier = 1;
            this.Hit = this.volition.Next(21);
            if (this.volition.Next(1, 21) == 1) this.Multiplier = 2;
            if (this.volition.Next(1, 21) == 2) this.Multiplier = 3;
            if (this.Hit == 0 && this.Multiplier == 3) this.Multiplier = 1;
        }
    }
}
