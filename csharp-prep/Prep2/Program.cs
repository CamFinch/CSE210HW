using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Grade Percentage: ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your Letter Grade Is A: {grade}");
        
        
    }
}

