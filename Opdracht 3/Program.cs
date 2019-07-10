using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amount of numbers?");
            int n = Convert.ToInt32(Console.ReadLine());        //amount of numbers to calculate average of

            double total = 0;                                      //total calculated of input numbers
            int temp;                                           //temporary storage for numbers to add to total
            double average;                                     //final average number

            for (int i = 0; i < n; i++)
            {
                Console.Write("Write down number" + i + ": ");
                temp = Convert.ToInt32(Console.ReadLine());     //convert input to integer and store in temp
                total += temp;                                  //add temp to total
            }

            average = total / n;
            Console.WriteLine(average + " is the average number");
            Console.ReadKey();                                  //prevent immediate shutdown
        }
    }
}
