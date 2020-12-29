using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ExcuseManager
{
    [Serializable]
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public Excuse()
        {
            
        }

        public Excuse(string fileName)
        {
            OpenFile(fileName);
        }

        public Excuse(Random random, string directory)
        {
            string[] fileNames = Directory.GetFiles(directory, "*.excuse");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        public void OpenFile(string excusePath)
        {
            try
            {
                this.ExcusePath = excusePath;
                BinaryFormatter formatter = new BinaryFormatter();
                Excuse tempExcuse;
                using (Stream input = File.OpenRead(excusePath))
                {
                    tempExcuse = (Excuse)formatter.Deserialize(input);
                }
                Description = tempExcuse.Description;
                Results = tempExcuse.Results;
                LastUsed = tempExcuse.LastUsed;
            }
            catch (SerializationException)
            {
                MessageBox.Show("Unable to read " + excusePath);
                LastUsed = DateTime.Now;
            }
        }
        public void Save(string fileName)
        {
            ExcusePath = fileName;
            using (Stream output = File.Create(fileName))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, this);
            }
        }
    }
}
