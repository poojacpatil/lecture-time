using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_time
{
    internal class prime_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int C = 0;

            for (int divisor = 1; divisor <= num; divisor++)
            {
                if (num % divisor == 0)
                {
                    Console.WriteLine(divisor);
                    C++;

                }
            }
            if(C==2)
                Console.WriteLine("Number is prime");
            else
                Console.WriteLine("Not prime");


            Console.Read();
        }
    }
}
















         
                    
               
                    
               
        
    

