using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sooraj_Suresh_Lab02_Excercise02
{
    class Program
    {
     private static int num;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Number:");
            var input = Console.ReadLine();
            try
            {
                if (int.TryParse(input, out num))
                {
                    Console.Write("The given number " + num , num++);                  
                    Console.Write(" has been incremented to " + num);
                    Console.ReadKey();
                }
                else
                {
                    throw new Exception(input);
                }
            }
            catch (Exception ex)
            {
                Console.Write("The given number " + input + " is incremented to " + input + 1);
                Console.ReadKey();
            }
        }
    }
}
