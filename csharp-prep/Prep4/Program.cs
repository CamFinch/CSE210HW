using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> myList = new List<int>();

        int listNum = -1;
        while (listNum != 0){

            Console.WriteLine("Enter Numbers to Be added to list, type 0 when finished: ");
            Console.WriteLine("Number to Add: ");
            string num = Console.ReadLine();
            listNum = int.Parse(num);



            if (listNum != 0){
                myList.Add(listNum);
            }

        }


        int sum = 0;
        foreach(int number in myList){
            sum += number;
        }

        Console.WriteLine($"The Total is {sum}");



        float avg = ((float)sum) / myList.Count;
        Console.WriteLine($"The average of the list is {avg}");


        int max = myList[0];
        
        foreach (int number in myList){
            if (number > max)
            max = number;
        }
        Console.WriteLine($"The Highest Number is {max}");

        




    }
}