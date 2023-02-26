using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class OxygenBottle : IVisitPort
    {
        protected double volume, weight;
        public double MaxCapacity { get; set; }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 2.6;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 2.6;
            }
        }

        public OxygenBottle (double capacity) { MaxCapacity = capacity; }
        
        public double VisitPort()
        {
            Volume = MaxCapacity;
            return 2.0 * MaxCapacity;
        }
        public double GetVolume() { return Volume; }
        public double GetWeight() { return Weight; }
        public void SetVolume(double weight) { GetVolume(); }
        public void SetWeight(double volume) { GetWeight(); }
        public double GetCapacity() { return MaxCapacity; }
    }
}

