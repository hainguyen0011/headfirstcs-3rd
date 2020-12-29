using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializeCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();

        private Deck RandomDeck(int number)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < number; i++)
            {
                myDeck.Add(new Card(
                    (Suits)random.Next(4),
                    (Values)random.Next(1, 13)));
            }
            return myDeck;
        }
        private void DealCards(Deck deckToDeal, string title)
        {
            Console.WriteLine(title);
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }
            Console.WriteLine("------------------");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck deckToWrite = RandomDeck(5);
            using (Stream output = File.Create("Deck1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, deckToWrite);
            }
            DealCards(deckToWrite, "What I just wrote to the file");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Deck1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Deck deckFromFile = (Deck)bf.Deserialize(input);
                DealCards(deckFromFile, "What I read from the file");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Deck2.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                for (int i = 0; i < 6; i++)
                {
                    Deck deckToWrite = RandomDeck(random.Next(1, 10));
                    formatter.Serialize(output, deckToWrite);
                    DealCards(deckToWrite, "Deck #" + i + " written");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Deck2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 0; i < 6; i++)
                {
                    Deck deckToRead = (Deck)bf.Deserialize(input);
                    DealCards(deckToRead, "Deck #" + i + " read");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Card sixHeart = new Card(Suits.Hearts, Values.Six);
            Card threeClub = new Card(Suits.Clubs, Values.Three);
            using (Stream outSix = File.Create("six-h.dat"))
            using (Stream outThree = File.Create("three-c.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(outSix, sixHeart);
                bf.Serialize(outThree, threeClub);
            }
            byte[] firstFile = File.ReadAllBytes("three-c.dat");
            byte[] secondFile = File.ReadAllBytes("six-h.dat");
            for (int i = 0; i < firstFile.Length; i++)
                if (firstFile[i] != secondFile[i])
                    Console.WriteLine("Byte #{0}: {1} versus {2}",
                    i, firstFile[i], secondFile[i]);
            firstFile[263] = (byte)Values.King; 
            firstFile[310] = (byte)Suits.Spades;
            File.Delete("king-s.dat");
            File.WriteAllBytes("king-s.dat", firstFile);
            using (Stream input = File.OpenRead("king-s.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Card deckToRead = (Card)bf.Deserialize(input);
                Console.WriteLine(deckToRead.Name);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"F:\Programs\IT\Programming Language\C#\hfcs\chap9\ConsoleApp1\bin\Debug\abc.txt"))
            //using (StreamWriter writer = new StreamWriter(@"c:\files\outputFile.txt", false))
            {
                char[] buffer = new char[16];
                int charactersRead = reader.ReadBlock(buffer, 0, 16);
                MessageBox.Show("The value is " + charactersRead + "  " + buffer);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"F:\Programs\IT\Programming Language\C#\hfcs\chap9\SerializeCard\bin\Debug\three-c.dat"))
            using (StreamWriter writer = new StreamWriter(@"F:\Programs\IT\Programming Language\C#\hfcs\chap9\SerializeCard\bin\Debug\hex dump.dat", false))
            {
                int position = 0;
                while (!reader.EndOfStream)
                {
                    char[] buffer = new char[16];
                    int charactersRead = reader.ReadBlock(buffer, 0, 16);
                    writer.Write("{0}: ", String.Format("{0:x4}", position));
                    position += charactersRead;
                    for (int i = 0; i < 16; i++)
                    {
                        if (i < charactersRead)
                        {
                            string hex = String.Format("{0:x2}", (byte)buffer[i]);
                            writer.Write(hex + " ");
                        }
                        else
                            writer.Write(" ");
                        if (i == 7) { writer.Write("-- "); }
                        if (buffer[i] < 32 || buffer[i] > 250) { buffer[i] = '.'; }
                    }
                    string bufferContents = new string(buffer);
                    writer.WriteLine(" " + bufferContents.Substring(0, charactersRead));
                }
            }
        }
    }
}
