using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_programs
{
    internal class Swapping
    {
        public void SwapingTwoNumbers()
        {
            Console.WriteLine("Enter the first number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the Value of first number is " + n);
            Console.WriteLine("the Value of second number is " + m);
            int c = 0;
            c = n;
            n = m;
            m = c;
            Console.WriteLine("the Value of first number after swap " + n);
            Console.WriteLine("the Value of second number after swap " + m);

        }
    }
}
