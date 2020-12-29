using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNameSpace
{
    class Program2
    {
        private int testNum = 0;
        
        public void testMethod(Program2 p2)
        {
            p2.testNum = 3;
            Console.WriteLine(p2.testNum);
        }
    }
}
