using System;

class EvenOdd
{
    static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("{0} is even", n);
        }
        else
        {
            Console.WriteLine("{0} is odd", n);
        }
        Console.ReadKey();
    }
}