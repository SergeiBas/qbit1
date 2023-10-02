using System;

namespace task19
{
    class Task19
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] timeComponents = input.Split(' ');

            if (timeComponents.Length == 3)
            {
                if (int.TryParse(timeComponents[0], out int H) &&
                    int.TryParse(timeComponents[1], out int M) &&
                    int.TryParse(timeComponents[2], out int S))
                {
                    if (H >= 0 && H <= 23 && M >= 0 && M <= 60 && S >= 0 && S <= 60)
                    {


                        S++;
                        if (S == 60)
                        {
                            S = 0;
                            M++;
                        }

                        if (M == 60)
                        {
                            M = 0;
                            H++;
                        }

                        if (H == 24)
                        {
                            H = 0;
                        }

                        Console.WriteLine($"{H} {M} {S}");
                    }

                }
            }
        }
    }
}