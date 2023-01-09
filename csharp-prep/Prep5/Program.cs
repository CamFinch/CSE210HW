using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string inputName = Name();
        int inputNum = InputNumber();

        int squared = squareRoot(inputNum);

        Information(inputName, inputNum);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome!");
    }
    static string Name(){

        Console.WriteLine("What is Your Name: ");
        string name = Console.ReadLine();

        return name;

    }

    static int InputNumber(){
        Console.WriteLine("Please Enter A Number: ");
        int num = int.Parse(Console.ReadLine());

        return num;
    }

    static int squareRoot(int num){
        int square = num * num;
        return square;
    }

    static void Information(string name, int square){
        Console.WriteLine($"Your Name {name}, Square Root Of Number Given: {square}");
    }
}