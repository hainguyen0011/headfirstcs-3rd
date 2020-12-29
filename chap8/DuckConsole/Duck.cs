using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckConsole
{
    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }
    class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duck other)
        {
            if (this.Size > other.Size)
                return 1;
            if (this.Size < other.Size)
                return -1;
            else
                return 0;
        }
        public override string ToString()
        {
            return Size++ +"-inch " + Kind;
        }
    }
}
