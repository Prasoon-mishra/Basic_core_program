namespace Basic_core_programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter 1 for Heads and Tails");
            int ans = Convert.ToInt32(Console.ReadLine());
            switch (ans)
            {
                case 1: 
                    FlipCoin Fc = new FlipCoin();
                    Fc.HeadsOrTailPercentage();
                    break;
                default:
                    Console.WriteLine("Entered value is incorrect");
                    break;
            }
        }
    }
}