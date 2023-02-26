using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class FuelTank : IVisitPort
    {
        protected double volume, weight;
        public double MaxCapacity { get; set; }
        private Fuel fuel;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 5.0;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 5.0;
            }
        }
        //public FuelTank() { }
        public FuelTank(double capacity, Fuel fuel) : base()
        {
            MaxCapacity = capacity;
            this.fuel = fuel;
        }
        public double VisitPort()
        {
            MaxCapacity -= Volume;
            Volume = MaxCapacity;
            return 10.0 * MaxCapacity;
        }
        public double GetVolume() { return Weight; }

        public double GetWeight() { return Volume; }
        public void SetVolume(double weight) { GetVolume(); }
        public void SetWeight(double volume) { GetWeight(); }
        public double GetCapacity() { return MaxCapacity; }
        public string GetFuelType() { return fuel.GetType(); }
    }
}
