using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_programs
{
        internal class LeapYear
        {
            public void leapYear()
            {
                Console.WriteLine("Leap year Program Enter the Year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    Console.WriteLine("{0} is a Leap year" + year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year " + year);
                }
            }
        }
}
