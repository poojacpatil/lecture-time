using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_time
{
    internal class Factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Accept number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % 1 == 0)


                    Console.WriteLine(i);
            }

                Console.Read();
           
        }
    }
}
