using System;

namespace task7
{
    class Task7
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            double a = Math.Round(double.Parse(input[0]),1);
            double b = Math.Round(double.Parse(input[1]),1);
            double c = Math.Round(double.Parse(input[2]),1);
            double x = Math.Round(double.Parse(input[3]),1);
            
            if (a >= 0.1 && a <= 10 && b >= 0.1 && b <= 10.0 && c >= 0.1 && c <= 10.0 && x >= 1.0 && x <= 1000.0)
            {
                double area = (200 * ((a * b) + (b * c) + (a * c)));
                int area2 = (int)Math.Ceiling(area * (x / 1000.0));
                Console.Write($"{area2}");
            }
            else
            {
                return;
            }
        }
        
        
    }
}