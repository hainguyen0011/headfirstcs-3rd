using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Program_1
{
    [Serializable]
    class Guy
    {
        public string Name;
        public int Cash;
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                this.Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " isn't an amount I'll take", Name + " say...");
                return 0;
            }
        }

        public int GiveCash(int amount)
        {
            if (this.Cash >= amount && amount > 0)
            {
                this.Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Don't have enough cash to give you " + amount, Name + " say...");
                return 0;
            }
        }

    }
}
