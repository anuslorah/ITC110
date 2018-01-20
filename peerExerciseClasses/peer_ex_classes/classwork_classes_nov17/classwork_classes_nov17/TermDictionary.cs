using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork_classes_nov17
{
    class TermDictionary
    {
        private List<Word> words;

        //constructor
        public TermDictionary()
        {
            words = new List<Word>(); //initializing words
        }

        public void AddWord(Word w)
        {
            words.Add(w);
        }

        public string GetDefinition(string wordTerm)
        {
            string def = null;

            foreach (Word w in words)
            {
                if (w.term.Equals(wordTerm))
                {
                    def = w.definition;
                }
            }

            return def;
        }



    }
}
