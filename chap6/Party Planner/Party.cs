using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class Party
    {
        public const decimal CostOfFoodPerPerson = 25.0M;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public virtual decimal Cost
        {
            get
            {
                decimal cost = (NumberOfPeople * CostOfFoodPerPerson) + CalculateCostOfDecoration();
                if (NumberOfPeople > 12)
                    return cost + 100M;
                return cost;
            }
        }

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
        }
        private decimal CalculateCostOfDecoration()
        {
            if (FancyDecorations)
                return (NumberOfPeople * 15.00M) + 50M;
            return (NumberOfPeople * 7.50M) + 30M;
        }
    }
}
