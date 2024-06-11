using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2021
{
    class Nachricht
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public Nachricht(string id, string text)
        {
            this.id = id;
            this.text = text;
        }

        public void drucke()
        {
            Console.WriteLine($"id: {id} \t text: {text}");
        }
    }
}
