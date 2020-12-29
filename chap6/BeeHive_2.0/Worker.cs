using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive_2
{
    class Worker : Bee
    {
        private string currentJob = "";
        public string CurrentJob { get { return currentJob; } }
        public int ShiftsLeft { get { return shiftsToWork - shiftsWorked; } }

        private string[] jobsICanDo;
        private int shiftsToWork = 0;
        private int shiftsWorked = 0;
        public Worker(string[] jobsICanDo, double weightMg) : base(weightMg)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job, int shift)
        {
            if (!String.IsNullOrEmpty(CurrentJob))
                return false;
            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (jobsICanDo[i] == job)
                {
                    currentJob = job;
                    shiftsToWork = shift;
                    return true;
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (!String.IsNullOrEmpty(CurrentJob))
            {
                Console.WriteLine(ShiftsLeft);
                shiftsWorked++;
                if (shiftsWorked > shiftsToWork)
                {
                    currentJob = "";
                    shiftsToWork = 0;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public override double HoneyConsumptionRate()
        {
            return base.HoneyConsumptionRate() + (0.65 * shiftsWorked);
        }
    }
}
