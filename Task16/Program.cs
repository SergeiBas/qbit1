using System;

namespace task16
{
    class Task16
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            double m = int.Parse(input[0]);
            double n = int.Parse(input[1]);
            if (m >= 1 && m <= 100000 && n >= 1 && n <= 100000)
            {
                double balls = (m / 3.0);
                double burulkas = Math.Ceiling(n / 4.0);
                double result = Math.Ceiling(balls + burulkas);
                Console.WriteLine($"{result}");
            }

        }
    }
}