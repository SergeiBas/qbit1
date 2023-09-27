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
            
            if (v1 >= 40 && v1 <= 180 && v2 >= 40 && v2 <= 180 && v3 >= 40 && v3 <= 180 && v4 >= 40 &&
                v4 <= 180)
            {
                double atob = ((v1 + v2) / 2.0) ;
                double btoa = ((2 * (v3 * v4)) / (v3 + v4));
                Console.WriteLine(atob);
                Console.WriteLine(btoa);
            }
        }
    }
}