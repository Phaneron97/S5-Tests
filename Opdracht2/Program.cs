using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a sentence: " );
            string text = Console.ReadLine();

            text = String.Join(" ", text.Split(' ').Reverse());

            Console.WriteLine(text);
            Console.ReadKey(); //prevent immediate shutdown
        }
    }
}
