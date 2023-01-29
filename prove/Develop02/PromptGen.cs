using System;
using System.IO;

class PromptGen
{

    public string prompt;


    public void GivePrompt(){
        Random num = new Random();
        int randomnumber = num.Next(0, 5);
        
            //"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?",
            //"What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"
        if(randomnumber == 1){
            prompt = "Who was the most interesting person I interacted with today?";
        }
        else if(randomnumber == 2){
            prompt = "What was the best part of my day?";
        }
        else if(randomnumber == 3){
            prompt = "How did I see the hand of the Lord in my life today?";
        }
        else if(randomnumber == 4){
            prompt = "What was the strongest emotion I felt today";
        }
        else if(randomnumber == 5){
            prompt = "If I had one thing I could do over today, what would it be?";
        }

        Console.WriteLine(prompt);

        
        

    }

    
}