using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World";

            text = String.Join(" ", text.Split(' ').Reverse());

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
