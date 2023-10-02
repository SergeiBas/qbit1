using System;

namespace task10
{
    class Task10
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split();
            double v1 = double.Parse(input[0]);
            double v2 = double.Parse(input[1]);
            double v3 = double.Parse(input[2]);
            double v4 = double.Parse(input[3]);
            double atob = (v1 + v2) / 2 ;
            double btoa = 2 * v3 * v4 / (v3 + v4);
            Console.WriteLine(string.Format("{0:F3}", atob));
            Console. Write(string.Format("{0:F3}", btoa));;
        }
    }
}