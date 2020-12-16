using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    var length = values.Length;
                    if (values[0] != "label")
                    {
                        Person person = new Person(values[0],String.Join(",",values.Skip(1)));
                        listPerson.Add(person);
                    }
                }
            }
            return listPerson;
        }
        public static void AddPerson(Person person)
        {
        }
    }
}
