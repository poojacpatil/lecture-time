using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_time
{
    internal class table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine($"{n}x{i}={n*i}");
            }

            Console.ReadLine();
        }
    }
}
