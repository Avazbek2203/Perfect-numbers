using System;

class Program
{
    static void Main()
    {
        int lowerBound = 0, upperBound = 0;
        bool validLower = false, validUpper = false;

        while (!validLower)
        {
            Console.Write("Enter the lower bound of the range: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out lowerBound))
            {
                validLower = true;
            }
            else
            {
                Console.WriteLine("Invalid input for lower bound, please try again.");
            }
        }

        while (!validUpper)
        {
            Console.Write("Enter the upper bound of the range: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out upperBound))
            {
                validUpper = true;
            }
            else
            {
                Console.WriteLine("Invalid input for upper bound, please try again.");
            }
        }

        for (int number = lowerBound; number <= upperBound; number++)
        {
            int quantity = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    quantity += i;
                }
            }

            if (quantity == number)
            {
                Console.WriteLine(number + " is a perfect number.");
            }
        }
    }
}
