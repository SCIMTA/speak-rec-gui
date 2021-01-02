using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakRec
{
    class Utils
    {
        public static List<Person> getListPerson()
        {
            List<Person> listPerson = new List<Person>();
            using (var reader = new StreamReader(@".\speak-rec\data\person.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (values[0] != "label")
                    {
                        Person person = new Person(values[0]);
                        listPerson.Add(person);
                    }
                }
            }
            return listPerson;
        }

        public static List<Person> getListJoin()
        {
            List<Person> listPerson = new List<Person>();
            using (var reader = new StreamReader(@".\speak-rec\data\join.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    var length = values.Length;
                    if (values[0] != "label")
                    {
                        Person person = new Person(values[0]);
                        listPerson.Add(person);
                    }
                }
            }
            return listPerson;
        }
        public static void replaceListPerson(List<Person> listPerson)
        {
            string createText = "label,emb\n";
            foreach (Person person in listPerson)
                createText += person.name + "\n";
            File.WriteAllText(@".\speak-rec\data\person.csv", createText);
        }

        public static Bitmap ConvertToGrayscale(Bitmap source)
        {
            var bm = new Bitmap(source.Width, source.Height);
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    Color c = source.GetPixel(x, y);
                    var luma = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    if (c.A != 0)
                        bm.SetPixel(x, y, Color.FromArgb(luma, luma, luma));
                }
            }
            return bm;
        }

        public static void disableButton(Button button, Bitmap bitmap, ToolStripMenuItem toolStripMenuItem)
        {
            button.BackgroundImage = ConvertToGrayscale(bitmap);
            toolStripMenuItem.Enabled = false;
            button.Enabled = false;
        }

        public static void enableButton(Button button, Bitmap bitmap, ToolStripMenuItem toolStripMenuItem)
        {
            button.BackgroundImage = bitmap;
            toolStripMenuItem.Enabled = true;
            button.Enabled = true;
        }
    }
}
