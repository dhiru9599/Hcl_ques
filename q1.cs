using System;

class Program
{
    public static void Main(string[] args)
    {
        
        int n = int.Parse(Console.ReadLine());

        int prevDigit = n % 10;
        n /= 10;
        bool increasing = true;
        bool decreasing = true;

        while (n > 0)
        {
            int currentDigit = n % 10;

            if (currentDigit == prevDigit)
            {
                Console.WriteLine("no");
                return; // Consecutive digits are equal
            }
            else if (currentDigit < prevDigit)
            {
                increasing = false; // Digits are not in increasing order
            }
            else
            {
                decreasing = false; // Digits are not in decreasing order
            }

            prevDigit = currentDigit;
            n /= 10;
        }

        if (increasing || decreasing)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
