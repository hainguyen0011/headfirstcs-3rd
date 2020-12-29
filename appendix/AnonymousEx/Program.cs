using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var someGuy = new { Name = "Bob", Age = 32, Cash = 127 };
            Console.WriteLine("{0} is {1} years old and has {2} bucks",
            someGuy.Name, someGuy.Age, someGuy.Cash);
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
                listOfNumbers.Add(random.Next(100));
            Console.WriteLine("There are {0} numbers",
            listOfNumbers.Count());
            Console.WriteLine("The smallest is {0}",
            listOfNumbers.Min());
            Console.WriteLine("The biggest is {0}",
            listOfNumbers.Max());
            Console.WriteLine("The sum is {0}",
            listOfNumbers.Sum());
            Console.WriteLine("The average is {0:F2}",
            listOfNumbers.Average());
            var under50sorted =
                                from number in listOfNumbers
                                where number < 50
                                orderby number descending
                                select number;
            List<int> newList = under50sorted.ToList();
        }
    }
}
