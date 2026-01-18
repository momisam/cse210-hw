using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Ask the user for numbers
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            // Do not add 0 to the list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // -------- Core Requirements --------

        // Find the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        // Find the average
        double average = (double)sum / numbers.Count;

        // Find the largest number
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        // -------- Stretch Challenge --------

        // Find the smallest positive number
        int smallestPositive = numbers[0];

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort the list
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    
    }
}