using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is Your First Name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is Your Last Name?");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your Name Is {lastName}, {firstName} {lastName} ");
    }
}