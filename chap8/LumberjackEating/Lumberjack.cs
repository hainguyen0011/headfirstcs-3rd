using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberjackEating
{
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount
        {
            get { return meal.Count; }
        }
        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            for (int i = 0; i < howMany; i++)
                meal.Push(food);
            
        }
        public void EatFlapjacks()
        {
            foreach (var food in meal)
            {
                Console.WriteLine(Name + " ate a " + food.ToString().ToLower() + " flapjack\n");
            }
        }
    }
}
