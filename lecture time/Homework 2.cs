using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_time
{
    internal class Homework_2
    {
        //1,4,9,16,25,36,49
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter the number of terms");
            int number=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i*i);
                
              


            }
            Console.ReadLine();
        }
    }
}
