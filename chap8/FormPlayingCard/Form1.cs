using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPlayingCard
{
    public partial class Form1 : Form
    {
        Random random;
        Deck deck1;
        Deck deck2;
        public Form1()
        {
            InitializeComponent();
            CreateObject();
        }

        public IEnumerable<Card> InitDeck1()
        {
            List<Card> temp = new List<Card>();
            for (int i = 0; i < 10; i++)
                temp.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 13)));
            return temp;
        }
        public void CreateObject()
        {
            random = new Random();
            deck1 = new Deck(InitDeck1());
            deck2 = new Deck();
            deck1.Sort();
            deck2.Sort();
            RedrawDeck();
        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {
            if (boxDeck2.SelectedIndex >= 0)
                if (deck2.Count > 0)
                {
                    Card cardToMove = deck2.Deal(boxDeck2.SelectedIndex);
                    deck1.Add(cardToMove);
                }
            RedrawDeck();
        }

        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            if (boxDeck1.SelectedIndex >= 0)
                if (deck1.Count > 0)
                {
                    Card cardToMove = deck1.Deal(boxDeck1.SelectedIndex);
                    deck2.Add(cardToMove);
                }
            RedrawDeck();
        }


        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        public void ResetDeck(int number)
        {
            if (number == 1)
                deck1 = new Deck(InitDeck1());
            else
                deck2 = new Deck();
            RedrawDeck(number);
        }

        private void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                boxDeck1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                    boxDeck1.Items.Add(cardName);
                label1.Text = "Deck #1 (" + deck1.Count + " cards)";
            }
            else
            {
                boxDeck2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                    boxDeck2.Items.Add(cardName);
                label2.Text = "Deck #2 (" + deck2.Count + " cards)";
            }
        }
        private void RedrawDeck()
        {
            RedrawDeck(1);
            RedrawDeck(2);
        }
    }
}
