using System;
using System.IO;
using System.Threading;
using System.Diagnostics;

public class Reflection : Control
{
    private string _reflectionDescription;

    public Reflection(string title, string reflectionDescription, string endingMessage)
        : base(title, endingMessage)
    {
        _reflectionDescription = reflectionDescription;
        
    }

    private string GetReflectionInfo(){
        return _reflectionDescription;
    }

    List<string> prompts1 = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult",
    "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    List<string> prompts2 = new List<string>{"Why was this expirience meaningful to you?", "Have you ever done anything like this before?",
    "How did you get started?", "How did you feel when it was completed?", "What made this time different than other times when you were not as succesful?",
    "What is your facorite thing about this expirience?", "What could you learn from this expirience that applies to other situatations?",
    "What did you learn about yourself through this experience?", "How can you keep this expeirience in mind in the fututre?"};
    

    public void GetRandomPrompt1(){
        Random random1 = new Random();
        int randomNumber1 = random1.Next(0, prompts1.Count);
        if(randomNumber1 == 1){
            Console.WriteLine(prompts1[0]);
        }
        else if(randomNumber1 == 2){
            Console.WriteLine(prompts1[1]);
        }
        else if(randomNumber1 == 3){
            Console.WriteLine(prompts1[2]);
        }
        else if(randomNumber1 == 4){
            Console.WriteLine(prompts1[3]);
        }
    }

    public void GetRandomPrompt2(){
        Random random2 = new Random();
        int randomNumber2 = random2.Next(0, prompts2.Count);
        if(randomNumber2 == 1){
            Console.WriteLine(prompts2[0]);
        }
        else if(randomNumber2 == 2){
            Console.WriteLine(prompts2[1]);
        }
        else if(randomNumber2 == 3){
            Console.WriteLine(prompts2[2]);
        }
        else if(randomNumber2 == 4){
            Console.WriteLine(prompts2[3]);
        }
        else if(randomNumber2 == 5){
            Console.WriteLine(prompts2[4]);
        }
        else if(randomNumber2 == 6){
            Console.WriteLine(prompts2[5]);
        }
        else if(randomNumber2 == 7){
            Console.WriteLine(prompts2[6]);
        }
        else if(randomNumber2 == 8){
            Console.WriteLine(prompts2[7]);
        }
        else if(randomNumber2 == 9){
            Console.WriteLine(prompts2[8]);
        }
    }
    

    public void ReflectionStart(){
        Console.WriteLine("");
        Console.WriteLine(GetActivityName());
        Thread.Sleep(200);
        Console.WriteLine("");
        Console.WriteLine(GetReflectionInfo());
        Thread.Sleep(200);
        bool timeActiveReflect = true;
        Console.WriteLine("\nHow Many Seconds Would You Like This Activity To Last?");
        string timeChoiceString = Console.ReadLine();
        int timeChoice = int.Parse(timeChoiceString);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timeChoice);
        GetRandomPrompt1();
        Stopwatch s = new Stopwatch();
        Stopwatch s2 = new Stopwatch();
        
        s.Reset();
        s.Start();
            while (s.Elapsed < TimeSpan.FromSeconds(7)) 
            {
                
                Animation();
            }
            Console.Write("\b\b");
            s.Stop();
            Console.Write("\b\b");
        while(timeActiveReflect){
            DateTime currentTime = DateTime.Now;
            if(currentTime > futureTime){
                timeActiveReflect = false;
            }
            Console.WriteLine("");
            GetRandomPrompt2();
            s2.Reset();
            s2.Start();
            while (s2.Elapsed < TimeSpan.FromSeconds(7)) 
            {
                Animation();
            }
            s2.Stop();
            s2.Reset();
            Console.Write("\b\b");
            
            
            if(currentTime > futureTime){
                timeActiveReflect = false;
            }
            
            
        }
        Console.WriteLine(GetEndingMessage());
        while(s.Elapsed < TimeSpan.FromSeconds(5)){
            Animation();
        }
        Console.WriteLine($"\n You reflected for {timeChoice} seconds!");
    }
    
}