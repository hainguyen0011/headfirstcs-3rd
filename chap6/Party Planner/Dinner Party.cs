using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }
        public override decimal Cost
        {
            get
            {
                decimal cost = base.Cost;
                cost += NumberOfPeople * CalculateCostOfBeveragesPerPerson();
                if (HealthyOption)
                    return cost * 0.95M;
                return cost;
            }
        }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
            : base(numberOfPeople, fancyDecorations)
        {
            HealthyOption = healthyOption;
        }
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
                return 5;
            return 20;
        }
    }
}
