using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPlayingCard
{
    class Deck
    {
        private List<Card> cards;
        private Random random;
        public int Count { get { return cards.Count; } }

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }
        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card cardToDeal = null;
            if (index >= 0 && index < Count)
            {
                cardToDeal = cards[index];
                cards.RemoveAt(index);
            }
            return cardToDeal;
        }

        public void Shuffle()
        {
            random = new Random();
            for (int i = 0; i < Count; i++)
            {
                int ranIndex = random.Next(Count);
                Card temp = cards[0];
                cards[0] = cards[ranIndex];
                cards[ranIndex] = temp;
            }
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] cardNames = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
                cardNames[i] = cards[i].Name;
            return cardNames;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }
    }
}
