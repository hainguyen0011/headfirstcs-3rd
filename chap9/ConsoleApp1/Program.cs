using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("abc.txt", "abc");
            byte[] arr = File.ReadAllBytes("abc.txt");
            File.WriteAllBytes("abc2.txt", arr);
        }
    }
}
