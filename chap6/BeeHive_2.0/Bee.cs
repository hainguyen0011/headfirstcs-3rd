using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive_2
{
    class Bee
    {
        public const double HoneyUnitsConsumedPerMg = 0.25;
        public double WeightMg { get; private set; }
        public Bee(double weightMg)
        {
            this.WeightMg = weightMg;
        }

        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}
