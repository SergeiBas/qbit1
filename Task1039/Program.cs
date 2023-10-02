using System;

class Program
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int dayOfWeekOfJan1 = 6;
        int dayOfWeek = (dayOfWeekOfJan1 + K - 1) % 7;
        if (dayOfWeek == 0)
            dayOfWeek = 7;
        Console.WriteLine(dayOfWeek);
    }
}