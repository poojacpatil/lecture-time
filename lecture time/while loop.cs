using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_time
{
    internal class while_loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            //45
            int sum = 0;
            int t = a;
            while (a > 0)
            {
                int d = a % 10;
                sum = sum + d;
                a = a / 10;
            }
            Console.WriteLine("Addition of digit is:{0}",sum);
            if(t%sum==0)
          
                Console.WriteLine("harshad or niven number");
            else
                Console.WriteLine("Not harshad or niven number");

            Console.Read();
        }
    }
}
