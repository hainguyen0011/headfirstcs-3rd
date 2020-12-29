using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCard
{
    public enum Suit
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,
    }
    public enum Value 
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    class Card
    {
        public Value Values { get; set; }
        public Suit Suits { get; set; }
        public string Name { get { return Values.ToString() + " of " + Suits; } }
        public Card(Value value, Suit suit)
        {
            Values = value;
            Suits = suit;
        }
        List
    }
}
