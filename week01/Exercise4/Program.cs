using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int user_num = -1;

        while (user_num != 0)
        {
            Console.WriteLine("Ender a number (0 to stop)");
            user_num = int.Parse(Console.ReadLine());

            if (user_num != 0)
            {
                numbers.Add(user_num);
            }
        }

        Console.WriteLine("You entered the following numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        //finding the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //finding the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //finding the highest number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}