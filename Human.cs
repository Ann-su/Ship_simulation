using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    abstract class Human :ITransportable
    {
        public double Volume { get; set; }
        public double Weight { get; set; }
        public abstract double GetVolume();
        public abstract double GetWeight();
        public abstract void SetVolume(double volume);
        public abstract void SetWeight(double weight);
    }
}
