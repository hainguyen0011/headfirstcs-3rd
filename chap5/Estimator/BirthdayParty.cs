using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator
{
    class BirthdayParty
    {
        public const decimal CostOfFoodPerPerson = 25.0M;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public decimal Cost
        {
            get
            {
                decimal cost = (NumberOfPeople * CostOfFoodPerPerson) + CalculateCostOfDecorations();
                decimal costCake;
                if (CakeSize() == 8)
                    costCake = 40 + (ActualLength * 0.25M);
                else
                    costCake = 75 + (ActualLength * 0.25M);
                return cost + costCake;
            }
        }
        public string CakeWriting { get; set; }
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                return false;
            }
        }
        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                return CakeWriting.Length;
            }
        }

        public BirthdayParty(int numberOfPeople,
                               bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            return 40;
        }
        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            return 16;
        }

        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
                return (NumberOfPeople * 15.00M) + 50M;
            return (NumberOfPeople * 7.50M) + 30M;
        }
    }
}
