using System;
using System.Collections.Generic;
using System.Linq;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Dictionary<char, int> DisplayDictionary = new Dictionary<char, int>();
            Console.WriteLine("enter a string");
            text = Console.ReadLine();

            Program p = new Program();
            DisplayDictionary =  p.getCount(text);

            foreach (KeyValuePair<char, int> pair in DisplayDictionary)
            {
                Console.WriteLine(pair.Key.ToString() + "  -  " + pair.Value.ToString());
            }

            Console.ReadLine();





        }


        public Dictionary<char, int> getCount(string name)
        {
            return name.GroupBy(x => x).ToDictionary(gr => gr.Key, gr => gr.Count());
        }
    }
}
