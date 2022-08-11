using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_programs
{
    internal class FlipCoin
    {
        public void HeadsOrTailPercentage()
        {
            Random random = new Random();
            Console.WriteLine("Enter the number of terms");
            int n = Convert.ToInt32(Console.ReadLine());
            double k = n;
            double head = 0D, tail = 0D;
            while (n > 0)
            {
                int checkValue = random.Next(0, 2);

                if (checkValue == 1)
                {
                    Console.WriteLine("Heads");
                    head++;

                }
                else
                {
                    Console.WriteLine("Tails");
                    tail++;
                }
                n--;

            }
            Console.WriteLine("Heads comes :" + head);
            Console.WriteLine("Tail comes :" + tail);
            Console.WriteLine("Heads Percentage : " + ((head / k) * 100));
            Console.WriteLine("Tailss Percentage : " + ((tail / k) * 100));
        }
    }
}
