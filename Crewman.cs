using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Crewman :Human
    {
        protected double volume, weight;
        public new double Volume { get { return volume; }
            set
            {
                volume = value;
                weight = value * 985.0; // average denisity of human body = 985 kg/m3
            }
        }
        public new double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 985.0;
            }
        }
        public override void SetVolume(double weight) { GetVolume(); }
        public override void SetWeight(double volume) { GetWeight(); }
        public override double GetVolume() { return Volume; }
        public override double GetWeight() { return Weight; } 
        
    }
}
