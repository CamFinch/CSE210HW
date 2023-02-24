using System;
using System.IO;
using System.Diagnostics;

public class Listing : Control
{
private string _listingDescription;


    public Listing(string title, string listingDescription, string endingMessage)
        : base(title, endingMessage)
    {
        _listingDescription = listingDescription;
        
    }
    private string GetListingInfo(){
        return _listingDescription;
    }

    List<string> listingPrompts = new List<string>{"Who are the people that you appreciate?", "What are personal strengths of yours?",
    "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public void GetRandomListing(){
        Random random = new Random();
        int randomNum = random.Next(0, listingPrompts.Count);
         if(randomNum == 1){
            Console.WriteLine(listingPrompts[0]);
        }
        else if(randomNum == 2){
            Console.WriteLine(listingPrompts[1]);
        }
        else if(randomNum == 3){
            Console.WriteLine(listingPrompts[2]);
        }
        else if(randomNum == 4){
            Console.WriteLine(listingPrompts[3]);
        }
        else if(randomNum == 5){
            Console.WriteLine(listingPrompts[4]);
        }
        
    }
    
    public void ListingStart(){
        Console.WriteLine("");
        Console.WriteLine(GetActivityName());
        Thread.Sleep(200);
        Console.WriteLine("");
        Console.WriteLine(GetListingInfo());
        Thread.Sleep(200);
        bool timeActiveListing = true;
        int numberItems = 0;
        Console.WriteLine("\nHow Many Seconds Would You Like This Activity To Last?\n");
        string timeChoiceString = Console.ReadLine();
        int timeChoice = int.Parse(timeChoiceString);
        GetRandomListing();
        DateTime startTime1 = DateTime.Now;
        DateTime futureTime1 = startTime1.AddSeconds(timeChoice);
        Console.WriteLine("\nBegin in 5...");
        Thread.Sleep(1000);
        Console.WriteLine("\n4...");
        Thread.Sleep(1000);
        Console.WriteLine("\n3...");
        Thread.Sleep(1000);
        Console.WriteLine("\n2...");
        Thread.Sleep(1000);
        Console.WriteLine("\n1...");
        while(timeActiveListing){
            DateTime currentTime1 = DateTime.Now;
            if(currentTime1 > futureTime1){
                timeActiveListing = false;
            }
            Console.WriteLine("\nItems to list: ");
            string items = Console.ReadLine();
            if(items != ""){
                numberItems ++;
            }
            
        }
        Console.WriteLine($"\nYou wrote {numberItems} things!");
        Stopwatch s = new Stopwatch();
        while (s.Elapsed < TimeSpan.FromSeconds(5)) 
        {
            Animation();
        }
        Console.Write("\b\b");
        s.Stop();
        s.Reset();
        Console.WriteLine(GetEndingMessage());
    }
}