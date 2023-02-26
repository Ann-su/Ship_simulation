using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Engine
    {
        private FuelTank tank;
        private Waste waste;
        public Engine(FuelTank tank, Waste waste)
        {
            this.tank = tank;
            this.waste = waste;
        }
        public void Travel(double travelTime)
        {
            for (double i = 0; i < travelTime; i++)
            {

                tank.Volume -= 10;
                waste.Volume += 100;
            }
        }
        public double GetVelocity(double submarineWeight)
        {
            if (submarineWeight <= 1000.0) return 45;
            return 40.0;

        }
        public bool CheckFuelBeforeTravel(double travelTime)
        {
            if (travelTime * .001 <= tank.Volume) return true;
            return false;
        }
    }
}
