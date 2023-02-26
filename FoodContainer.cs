using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class FoodContainer :IVisitPort
    {
        protected double volume, weight;
        public double MaxCapacity { get; set; }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 6.0;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 6.0;
            }
        }

        public FoodContainer(double capacity) { MaxCapacity = capacity; }

        public double VisitPort()
        {
            MaxCapacity -= Volume;
            Volume = MaxCapacity;
            return 20 * MaxCapacity;
        }

        public double GetVolume() { return Volume; }
        public double GetWeight() { return Weight; }
        public void SetVolume(double weight) { GetVolume(); }
        public void SetWeight(double volume) { GetWeight(); }
        public double GetCapacity() { return MaxCapacity; }
    }
}
