using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers)
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
            shiftNumber++;
            string report = "";
            report += String.Format("Report for shift #{0}\r\n", shiftNumber);
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    report += String.Format("Worker #{0}: Finish the job\r\n", i + 1);
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += String.Format("Worker #{0}: is not working\r\n", i + 1);
                else
                    if (workers[i].ShiftsLeft > 0)
                    report += String.Format("Worker #{0}: is doing '{1}' for {2} more shifts\r\n",
                                                i + 1, workers[i].CurrentJob, workers[i].ShiftsLeft);
                else
                    report += String.Format("Worker #{0}: will be done with '{1}' after this shift\r\n",
                                                i + 1, workers[i].CurrentJob);

            }
            return report;
        }
    }
}
