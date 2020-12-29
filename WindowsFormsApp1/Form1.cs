using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SomeMethod();
        }
        public void SomeMethod()
        {
            Line[] lines = {
                    new Line( new string[] { "eating", "carrots,", "but", "enjoy", "Horses" } , 1),
                    new Line( new string[] { "zebras?", "hay", "Cows", "bridge.", "bolted" } , 2),
                    new Line( new string[] { "fork", "dogs!", "Engine", "and" }, 3 ) ,
                    new Line( new string[] { "love", "they", "apples.", "eating" }, 2 ) ,
                    new Line( new string[] { "whistled.", "Bump" }, 1 )
            };
            var words =
                from line in lines
                group line by line.Value
                into wordGroups
                orderby wordGroups.Key
                select wordGroups;
            var twoGroups = words.Take(2);
            foreach (var group in twoGroups)
            {
                string typeOfGroup = group.GetType().Name;
                int i = 0;
                foreach (var inner in group)
                {
                    i++;
                    if (i == group.Key)
                    {
                        var poem =
                            from word in inner.Words
                            orderby word descending
                            select word + " ";
                        foreach (var word in poem)
                            Console.Write(word);
                    }
                }
            }
        }
    }
    class Line
    {
        public string[] Words;
        public int Value;
        public Line(string[] Words, int Value)
        {
            this.Words = Words; this.Value = Value;
        }
    }

}
