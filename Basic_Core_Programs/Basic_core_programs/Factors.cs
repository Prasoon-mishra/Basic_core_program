using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_programs
{
    internal class Factors
    {

        public void PrimeFactors()
        {
            int c = 2;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 1)
            {
                if (n % c == 0)
                {
                    Console.Write(c + " ");
                    n /= c;
                }
                else
                    c++;
            }
        }
    }
}
