using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Waste :IVisitPort
    {
        protected double volume, weight;
        public double MaxCapacity { get; set; }

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 2.5;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 2.5;
            }
        }
        public double VisitPort()
        {
            MaxCapacity -= Volume;
            Volume = 0;
            return 5 * MaxCapacity;
        }
        public double GetVolume() { return Weight; }

        public double GetWeight() { return Volume; }

        public void SetVolume(double volume) { volume = MaxCapacity; }
        public void SetWeight(double weight) { weight = Weight; }
        public double GetCapacity() { return MaxCapacity; }
    }
}
