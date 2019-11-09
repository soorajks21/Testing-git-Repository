using System;
using System.Collections.Generic;
using System.Linq;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
           char[] values = new char[10] ;
       
            LinkedList<Char> list = new LinkedList<Char>();
            LinkedList<Char> reverseList = new LinkedList<Char>();

           
            
            Console.WriteLine("enter the String");
            string data = Console.ReadLine();

            var result = new String(data.Where(x => !Char.IsPunctuation(x) && !Char.IsWhiteSpace(x)).ToArray());
            foreach(var dataValue in result)
            {
                list.AddLast(dataValue);
            }


            Console.WriteLine("First Linkedlist");
            foreach (var l in list)
            {
                Console.WriteLine(l);
               
               
            }


            var el = list.Last;
            while(el != null)
            {
                reverseList.AddLast(el.Value);
                // Console.WriteLine(el.Value);
                el = el.Previous;
              
               
            }

            Console.WriteLine("In reverse order LinkedList");
            foreach (var l in reverseList)
            {
                Console.WriteLine(l);


            }

            Console.ReadLine();


        }
    }
}
