using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1
{
    public class Elephant
    {
        public int EarSize;
        public string Name;

        public string WhoAmI()
        {
            string res = "My ears are " + this.EarSize + " inches tall";
            return res;
            //MessageBox.Show("My ears are " + this.EarSize + " inches tall.",
            //        this.Name + " says…");
        }
    }
}
