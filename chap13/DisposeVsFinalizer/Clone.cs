using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DisposeVsFinalizer
{
    [Serializable]
    class Clone : IDisposable
    {
        public int Id { get; private set; }
        public Clone(int Id)
        {
            this.Id = Id;
        }
        public void Dispose()
        {
            MessageBox.Show("I’ve been disposed!",
                    "Clone #" + Id + " says...");
            string path = @"F:\Programs\IT\Programming Language\C#\hfcs\chap13\DisposeVsFinalizer\temp\";
            string fileName = path + @"Clone.dat";
            if (!File.Exists(fileName))
                Directory.CreateDirectory(path);
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output = File.OpenWrite(fileName))
            {
                bf.Serialize(output, this);
            }
            MessageBox.Show("Must...serialize...object!",
                                "Clone #" + Id + " says...");
        }
        ~Clone()
        {
            MessageBox.Show("Aaargh! You got me!",
                    "Clone #" + Id + " says...");
        }
    }
}
