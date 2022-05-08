using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_time
{
    internal class sum_of_10_odd_no
    {
        static void Main(string[] args)

        {
            int sum = 0;
            for (int i = 1; i <= 23; i = i + 2)
           
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }

            Console.Read();
        }
    }
}



