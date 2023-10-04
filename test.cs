using System;

class Program
{
    static void Main()
    {
        int n;
        if (int.TryParse(Console.ReadLine(), out n))
        {
            Console.Write(" ");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }
}
