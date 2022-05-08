using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_time
{
    internal class sum
    {
        static void Main(string[] args)
        {
            //1+2+3+4+5+6......+20
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum = sum + i;
            }
                Console.WriteLine(sum);
            

            Console.Read();
        }
    }
}
