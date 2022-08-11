using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_programs
{
    internal class PowerOFTwo
    {
        public void powOfTwo()
        {
            int res = 1;
            Console.WriteLine("Power of Two Enter the number of terms");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0 || num > 31)
            {
                Console.WriteLine("Enter the terms between range 1 to 31");
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    res = res * 2;
                    Console.WriteLine("Power of 2 raise to" + i + " is " + res);
                }
            }
        }
    }
}
