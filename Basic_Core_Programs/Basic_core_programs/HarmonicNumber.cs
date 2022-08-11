using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_programs
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.WriteLine("Harmonic number series program");
            Console.WriteLine("Enter the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double i = 1;
            double sum = 0;
            while (i <= n)
            {
                sum = sum + (1 / i);
                i++;
            }
            Console.WriteLine("The sum of " + i + "th term is=" + sum);
        }
    }
}
