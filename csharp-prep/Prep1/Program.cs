using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.Write("What is your name? ");
        string lastName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string firstName = Console.ReadLine();
        
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        
        
    }
}