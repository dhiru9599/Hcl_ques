using System;

class Program
{
    static bool IsSorted(int n)
    {
        int prevDigit = n % 10;
        n /= 10;
        bool increasing = true;
        bool decreasing = true;

        while (n > 0)
        {
            int currentDigit = n % 10;

            if (currentDigit == prevDigit)
            {
                return false; // Consecutive digits are equal
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

        return increasing || decreasing;
    }

    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 100 && n <= 999 && IsSorted(n))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
