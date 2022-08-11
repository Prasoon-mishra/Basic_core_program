using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_programs
{
    internal class LargestAmongThree
    {
        public void Largest()
        {
            Console.WriteLine("Enter the first number;");
            int firstNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number;");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number;");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber > secondNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("First is the largest number");
            }
            else if (secondNumber > thirdNumber )
            {
                Console.WriteLine("Second is the largest number");
            }
            else 
            {
                Console.WriteLine("Third is the largest number");
            }

        }
    }
}
