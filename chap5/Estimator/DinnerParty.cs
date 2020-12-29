using System;

namespace Estimator
{
    class DinnerParty
    {

        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Cost
        {
            get
            {
                decimal cost = NumberOfPeople * (25 + CalculateCostOfBeveragesPerPerson())
                    + CalculateCostOfDecorations();
                if (HealthyOption)
                    return cost * 0.95M;
                return cost;
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
            {
                return 15.0M * NumberOfPeople + 50.0M;
            }
            else
            {
                return 7.5M * NumberOfPeople + 30.0M;
            }
        }
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
            {
                return 5;
            }
            else
            {
                return 20;
            }
        }
    }
}