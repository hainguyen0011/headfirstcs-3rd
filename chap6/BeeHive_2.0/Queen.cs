using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive_2
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers, double weightMg) : base(weightMg)
        {
            this.workers = workers;
        }
        public bool AssignWork(string job, int shift)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    if (workers[i].DoThisJob(job, shift))
                        return true;
                }
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            double consumption = this.HoneyConsumptionRate();
            shiftNumber++;
            string report = "";
            report += String.Format("Report for shift #{0}\r\n", shiftNumber);
            for (int i = 0; i < workers.Length; i++)
            {
                consumption += workers[i].HoneyConsumptionRate();
                if (workers[i].DidYouFinish())
                    report += String.Format("Worker #{0}: Finish the job\r\n", i + 1);
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += String.Format("Worker #{0}: is not working\r\n", i + 1);
                else
                if (workers[i].ShiftsLeft > 0)
                {
                    report += String.Format("Worker #{0}: is doing '{1}' for {2} more shifts\r\n",
                                                i + 1, workers[i].CurrentJob, workers[i].ShiftsLeft);
                }
                else
                {
                    report += String.Format("Worker #{0}: will be done with '{1}' after this shift\r\n",
                                                i + 1, workers[i].CurrentJob);
                    consumption += workers[i].HoneyConsumptionRate();
                }
            }
            report += String.Format("Total honey consumed for the shift: {0} units\r\n", consumption);
            return report;
        }
    }
}
