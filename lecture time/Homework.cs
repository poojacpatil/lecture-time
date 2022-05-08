using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_time
{
    internal class Homework

    {

        // 0,1,1,2,3,5,8,13,21,34....
        static void Main(string[] args)
        {
            int number, t1 = 0, t2 = 1, nextterm;
            Console.WriteLine("Enter the number of terms");
             number = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=number;i++)
            {
                Console.WriteLine("0="+t1);
                nextterm = t1 + t2;
                t1 = t2;
                t2 = nextterm;
            }
            Console.ReadLine();
        }
    }
}
