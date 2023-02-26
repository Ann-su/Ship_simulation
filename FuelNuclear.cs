using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class FuelNuclear :Fuel
    {
        protected double density = 2.5;
        protected double volume, weight;
        public override string GetType() { return Type = "Nuclear"; }
        public new double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * density;
            }
        }
        public new double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / density; 
            }
        }
        public override void SetVolume(double weight) { GetVolume(); }
        public override void SetWeight(double volume) { GetWeight(); }
        public override double GetVolume() { return Volume; }
        public override double GetWeight() { return Weight; }
    }
}
