using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_time
{
    internal class multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= 20; i++) 
            {
                sum = sum * i;
                Console.WriteLine("sum");
            }
        }
    }
}
