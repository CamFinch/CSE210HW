using System;
using System.IO;

public class Journal
{
    public string prompt, read;
    Entry entry1 = new Entry();

    
    public List<string> newEntries = new List<string>{};
  

    public void Menu(){
        int i = 1;
        while(i == 1){
            Console.WriteLine("Select a Choice: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit ");

            string choice = Console.ReadLine();
            
            if (choice == "1"){
                // Write
                RandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                string newEntry = Console.ReadLine();
                newEntries.Add(newEntry);
                entry1._response = newEntry;


            }
            else if (choice == "2"){
                //Display
                
                entry1.DisplayEntry();
                
            
            }

            else if (choice == "3"){
                //Load
                Load();
                
              
            }

            else if (choice == "4"){
                //Save
                Save();
                
            }

            else if (choice == "5"){
                //Quit
                i++;
            
            }
            else{
                Console.WriteLine("Incorrect Input Please Try Again!");
                
            }
        }
    }
   
    public void RandomPrompt(){
        Random random = new Random();
        
        int randomNumber = random.Next(1, 5);

        if(randomNumber == 1){
            prompt = "Who was the most interesting person I interacted with today?";
        }
        else if(randomNumber == 2){
            prompt =  "What was the best part of my day?";
        }
        else if(randomNumber == 3){
            prompt = "How did I see the hand of the Lord in my life today?";
        }
        else if(randomNumber == 4){
            prompt =  "What was the strongest emotion I felt today?";
        }
        else if(randomNumber == 5){
            prompt = "If I had one thing I could do over today, what would it be?";
        }

        entry1._prompt = prompt;
        
        

    }


    public void Load(){
        Console.WriteLine("Enter File To Load From: ");
        string fileName = Console.ReadLine();

        List<string> lines = System.IO.File.ReadAllLines(fileName).ToList();

        foreach(string line in lines)
        {
            entry1._response = line;

        }
         
        Menu();
        
    }

    public void Save(){
        Console.WriteLine("Name The File To Be Saved To: ");
        string newFileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(newFileName)){
            outputFile.WriteLine($"{entry1._date} \nPrompt: {prompt} \n{entry1._response}");
        
        
    }
    }
    


    
}