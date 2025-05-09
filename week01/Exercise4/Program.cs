using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        List<int> numbers = new List<int>(); 
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0) 
            {
                numbers.Add(number); // Add the number to the list
            }
        } while (number != 0);
        //Compute the sum, or total, of the numbers in the list.
        int sum = numbers.Sum();
        // Compute the average of the numbers in the list.
        double average = (double)sum / numbers.Count;
        // Find the maximum, or largest, number in the list.
        int maxNumber = numbers.Max();
        Console.WriteLine($"The sum is: {sum.ToString()}");
        Console.WriteLine($"The average is: {average.ToString()}");
        Console.WriteLine($"The maximum number is: {maxNumber.ToString()}");
    }
}