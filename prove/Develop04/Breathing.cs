using System;
using System.IO;
using System.Diagnostics;

public class Breathing : Control
{
    private string _breathDescription;
    

    public Breathing(string title, string breathDescription, string endingMessage)
        : base(title, endingMessage)
        {
            _breathDescription = breathDescription;
        }

    private string GetBreathingInfo(){
        return _breathDescription;
    }


    public void BreathIn(){
        Console.Write("\nBreathe In...");
        Console.Write("5");
        Console.Write("\b");
        Thread.Sleep(1000);
        Console.Write("4");
        Console.Write("\b");
        Thread.Sleep(1000);
        Console.Write("3");
        Console.Write("\b");
        Thread.Sleep(1000);
        Console.Write("2");
        Console.Write("\b");
        Thread.Sleep(1000);
        Console.Write("1"); 
        Thread.Sleep(1000);
    }

    public void BreathOut(){
        Console.Write("\nBreathe Out...");
        Console.Write("5");
        Console.Write("\b");
        Thread.Sleep(1000);
        Console.Write("4");
        Console.Write("\b");
        Thread.Sleep(1000);
        Console.Write("3");
        Console.Write("\b");
        Thread.Sleep(1000);
        Console.Write("2");
        Console.Write("\b");
        Thread.Sleep(1000);
        Console.Write("1"); 
        Thread.Sleep(1000);
    }


    public void BreathingStart(){
        Console.WriteLine("");
        Console.WriteLine(GetActivityName());
        Console.WriteLine("");
        Thread.Sleep(200);
        Console.WriteLine(GetBreathingInfo());
        Console.WriteLine("");
        Thread.Sleep(200);
        bool timeActive = true;
        Console.WriteLine("\nHow Many Seconds Would You Like This Activity To Last?");
        string timeChoiceString = Console.ReadLine();
        int timeChoice = int.Parse(timeChoiceString);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timeChoice);
            while(timeActive){
                DateTime currentTime = DateTime.Now;
                if(currentTime > futureTime){
                    timeActive = false;
                }
                BreathIn();
                BreathOut();
                
            }
            
            Console.WriteLine(GetEndingMessage());
            Stopwatch s = new Stopwatch();
            s.Reset();
            s.Start();
            while (s.Elapsed < TimeSpan.FromSeconds(5)) 
            {
                Animation();
            }
            Console.WriteLine("\b\b");
            s.Stop();
            s.Reset();
            
            Console.WriteLine($"\nYou Have Completed {timeChoiceString} Seconds Of Breathing!!\n");

            
            
            
                
    }

}