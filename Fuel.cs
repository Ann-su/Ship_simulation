using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    abstract class Fuel :ITransportable
    {
        public string Type { get; set; }
        public double Volume { get; set; }
        public double Weight {get; set; }
        
        public new abstract string GetType();

        public abstract void SetVolume(double weight);
        public abstract void SetWeight(double volume);
        public abstract double GetVolume();
        public abstract double GetWeight();
    }
}
