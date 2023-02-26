using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace HW3 
{
    internal class LifeSupportSystem
    {
        private Waste waste;
        private FoodContainer foodContainer;
        private List<OxygenBottle> oxygenBottles;
        private List<Human> crew;
        public double MaxCapacity { get; set; }

        //Constructor 
        public LifeSupportSystem(List<OxygenBottle> oxygenBottles, FoodContainer foodContainer, Waste waste, List<Human> crew)
        {
            this.waste = waste;
            this.foodContainer = foodContainer;
            this.oxygenBottles = oxygenBottles;
            this.crew = crew;
        }
        public bool CheckSuppliesBeforeTravel(double travelTime)
        {
            if (foodContainer.Volume == foodContainer.MaxCapacity && oxygenBottles.Count >= (travelTime/5.0) && crew.Count >= 2)
                return true;
            return false;
        }
        public void Run(double travelTime)
        {
            for (int i = 0; i < travelTime; i++)
            {
                foodContainer.Volume -= 1;
                waste.Volume += 2;
                for (int j = 0; j < oxygenBottles.Count; j++) oxygenBottles[j].Volume -= 1;
            }
        }
    }
}
