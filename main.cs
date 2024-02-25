using System;

class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        string message = "";

        while (true)
        {
            Console.Write("Enter something: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int number))
            {
                total += number;
                Console.WriteLine($"Adding {number} to {total - number} = {total}");
            }
            else
            {
                message += input;
                Console.WriteLine($"Current Message is: {message}");
            }
        }

        Console.WriteLine("Closing Program...");
    }
}
