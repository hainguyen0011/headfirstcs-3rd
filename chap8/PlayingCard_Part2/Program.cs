using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCard_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Card> desk = new List<Card>()
            {
                new Card((Value)random.Next(1,13),(Suit)random.Next(4)),
                new Card((Value)random.Next(1,13),(Suit)random.Next(4)),
                new Card((Value)random.Next(1,13),(Suit)random.Next(4)),
                new Card((Value)random.Next(1,13),(Suit)random.Next(4)),
                new Card((Value)random.Next(1,13),(Suit)random.Next(4)),
            };
            CardComparer_byValue cardComparer = new CardComparer_byValue();
            PrintCard(desk);
            desk.Sort(cardComparer);
            PrintCard(desk);

        }
        public static void PrintCard(List<Card> desk)
        {
            foreach (Card card in desk)
            {
                Console.WriteLine(card);
            }
        }
    }
}
