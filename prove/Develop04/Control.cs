using System;
using System.IO;

public class Control{

    private string _title;
    private string _endingMessage;
    public bool animationActive = true;

    public Control(string title, string endingMessage){
        
        _title = title;
        _endingMessage = endingMessage;
        
    }
    public string GetActivityName(){
        return _title;
    }

    public string GetEndingMessage(){
        return _endingMessage;
    }
    public void Animation(){
        
        List<string> animationVar = new List<string>{"/", "-", "\\", "|"};
        
        foreach(string s in animationVar){
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b\b");

        }
        
        
    }
    

   // public void GetTime(){
       // Console.WriteLine("How Many Seconds Would You Like This Activity To Last?");
        //string timeChoiceString = Console.ReadLine();
        //int timeChoice = int.Parse(timeChoiceString);
        //int choiceMilliseconds = timeChoice * 1000;
        //TimeSpan interval = new TimeSpan(0, 0, timeChoice);

    //}
    
    
}