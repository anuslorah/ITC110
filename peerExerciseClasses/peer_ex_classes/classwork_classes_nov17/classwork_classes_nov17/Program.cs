using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork_classes_nov17
{
    class Program
    {
        TermDictionary td = new TermDictionary();
        static void Main(string[] args)
        {
            Program p = new classwork_classes_nov17.Program();
            Word w1 = new Word();
            w1.term = "shirt";
            w1.definition = "garment with sleeves";
            p.td.AddWord(w1);

            Word w2 = new Word();
            w2.term = "cat";
            w2.definition = "feline";
            p.td.AddWord(w2);

            Word w3 = new Word();
            w3.term = "dog";
            w3.definition = "canine";
            p.td.AddWord(w3);

            Console.WriteLine("enter a word for definition");
            string searchWord = Console.ReadLine();

            string def = p.td.GetDefinition(searchWord);
            if (def !=null)
            {
                Console.WriteLine(def);
            } 
            else
            {
                Console.WriteLine("not in the dictionary");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
