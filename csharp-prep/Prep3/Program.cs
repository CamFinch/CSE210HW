using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNum = new Random();
        int num = randomNum.Next(1, 100);

        int i = -1;

        while (i != num){
            Console.WriteLine("Guess A Number Between 1-100: ");
            i = int.Parse(Console.ReadLine());

            if (num < i){
                Console.WriteLine("Lower");

            }
            else if (num > i){
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("Correct!");
            }

        }
        
        


    }
}