using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClown
{
    class FunnyFunny:IClown
    {
        protected string funnyThingIHave;


        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public string FunThingIhave { get { return "Hi kid! I have a " + funnyThingIHave; } }

        public void Honk()
        {
            Console.WriteLine(this.FunThingIhave);
        }
    }
}
