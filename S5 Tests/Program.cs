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
            //array for all texts
            string[] text = new string[3];

            text[0] = "Hello World";
            text[1] = "Bye World";
            text[2] = "Useless World";
            
            for (int i = 0; i <3; i++)
            {
                //get string from textarray, split through space and reverse words
                text[i] = String.Join(" ", text[i].Split(' ').Reverse());

                Console.WriteLine(text[i]);
            }

            //prevent immediate shutdown
            Console.ReadKey();
        }
    }
}
