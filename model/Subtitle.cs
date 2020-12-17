using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakRec.model
{
    class Subtitle
    {
        public string name, time, text;
        public Subtitle(string name, string time, string text)
        {
            this.name = name;
            this.time = time;
            this.text = text;
        }
    }
}
