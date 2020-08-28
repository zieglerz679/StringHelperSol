using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHelper
{
    public class PocitadloPismen
    {
        private string text;
        public string Text
        {
            get { return text; }
            set { 
                text = value;
                seznam.Clear();
            }
        }

        private readonly Dictionary<char, int> seznam = new Dictionary<char, int>();

        public int this[char c]
        {
            get
            {
                if (seznam.ContainsKey(c))
                    return seznam[c];

                int pocet = 0;
                foreach (char item in Text)
                {
                    if (item == c)
                        pocet++;
                }
                seznam.Add(c, pocet);
                return pocet;
            }
        }

        public void Akce() { }
    }
}
