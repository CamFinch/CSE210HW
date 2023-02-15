using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Cameron Finch", "Math");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Cameron Finch", "Addition", "1.3", "1-5");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Cameron Finch", "World History", "The Mongol Empire");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritinInfo());
    }
}