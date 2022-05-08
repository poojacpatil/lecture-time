using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_time
{
    internal class Homework4
    {
        //0,3,8,15,24,35,48....nterms
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms");
             int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i*i-1);
            }

            Console.Read(); 
        }
    }
}
