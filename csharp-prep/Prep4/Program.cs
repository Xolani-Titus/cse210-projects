using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numberFromUser = -1;
        while (numberFromUser != 0)
        {
            Console.WriteLine("Enter number (0 to quit): ");
            string userReply = Console.ReadLine();
            numberFromUser = int.Parse(userReply);

            if (numberFromUser != 0)
            {
                numbers.Add(numberFromUser);
            }
        }

        //Calculate the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Sum: {sum}");

        //Calculate average
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"Average: {average}");

        //Maximum number
        int max = numbers[0];
        foreach (int number in numbers)
        {
                if (number > max)
        {
            max = number;
        }
        }
        Console.WriteLine($"Maximum: {max}");
        





        
    }
}