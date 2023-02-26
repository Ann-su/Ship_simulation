using System;
using System.Collections.Generic;
using System.Text;

namespace HW3
{
    interface ITransportable
    {
        // anything we can transport is ITransportable
        // examples: people, food, waste, fuel, equipment
        // each transportable item has to know its volume in m^3 and weight in tonnes
        // important: if you change volume, weight should update automatically and vice versa
        // you can use any numbers you want - don't worry about being realistic
		// see Equipment.cs for an example implementation
        public double Volume { get; set; } 
        public double Weight { get; set; }
        public double GetVolume();
        public double GetWeight();
        public void SetVolume(double volume);
        public void SetWeight(double weight);

    }
}
