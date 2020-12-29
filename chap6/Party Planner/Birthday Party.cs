using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class BirthdayParty : Party
    {
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
        public override decimal Cost
        {
            get
            {
                decimal cost = base.Cost;
                decimal costCake;
                if (CakeSize() == 8)
                    costCake = 40 + (ActualLength * 0.25M);
                else
                    costCake = 75 + (ActualLength * 0.25M);
                return cost + costCake;
            }
        }
        public int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                return CakeWriting.Length;
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
            : base(numberOfPeople, fancyDecorations)
        {
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
    }
}
