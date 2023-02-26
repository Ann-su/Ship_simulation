using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Scientist :Human
    {
        private Equipment equipment = new Equipment();
        public Scientist(Equipment equipment)
        {
            this.equipment = equipment;
        }
        public void Work(double time)
        {
            for(int i = 0; i < time; i += 24)
            {
                Console.WriteLine(equipment.GatherData());   
            }
        }
        protected double volume, weight;
        public new double Volume { get { return volume; }
            set
            {
                volume = value;
                if (value > 0) weight = value * 3.0; 
            }
        }
        public new double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                if (value > 0 ) volume = value / 3.0;
            }
        }
        public override void SetVolume(double weight) { GetVolume(); }
        public override void SetWeight(double volume) { GetWeight(); }
        public override double GetVolume() { return Weight; }
        public override double GetWeight() { return Volume; } 
    }
}
