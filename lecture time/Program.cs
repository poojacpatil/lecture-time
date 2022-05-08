using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  number");
            int num = Convert.ToInt32(Console.ReadLine());
            if ( num%7== 0)
                Console.WriteLine("divisible number");
            else
                Console.WriteLine("not divisible number");

        }
    }
}
