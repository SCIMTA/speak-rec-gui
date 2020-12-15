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
            using (var reader = new StreamReader(@".\data.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Person person = new Person(values[0], values[1]);
                    listPerson.Add(person);
                }
            }
            return listPerson;
        }
        public static void AddPerson(Person person)
        {
            List<Person> listPerson = getListPerson();
            listPerson.Add(person);
            using (var writer = new StreamWriter(@".\data.csv"))
            {
                foreach(Person per in listPerson)
                    writer.WriteLine(per.name+","+ per.featured);
            }
        }
    }
}
