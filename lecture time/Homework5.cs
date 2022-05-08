using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_time
{
    internal class Homework5
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial="+fact);

            Console.Read();
        }
    }
}
