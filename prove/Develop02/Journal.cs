using System;
using System.IO;

class Journal
{

    public string fileName;
    public string journalEntry;
    public string choice;
    public string writeLoad;

    Entry entry2 = new Entry();
    PromptGen prompt1 = new PromptGen();



    public void Start(){

        FindChoice();
        
    }
    public void FindChoice(){
        int i = 0;

        do
        {
        
      
            Console.WriteLine("Select a Choice: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit ");

            string choice = Console.ReadLine();

            if (choice == "1"){
                // Write
                Write();
                i++;
                
        
            }
            else if (choice == "2"){
                //Display
                Display();
                i++;
            
            }

            else if (choice == "3"){
                //Load
                i++;
                entry2.Load();
              
            }

            else if (choice == "4"){
                //Save
                entry2.Save();
                i++;

            }

            else if (choice == "5"){
                //Quit
                i++;
                
            
            }
            else{
                Console.WriteLine("Incorrect Input Please Try Again!");
                
            }

        }while(i <= 1);
    }


    public void Write(){
        
        Console.WriteLine($"Prompt: {prompt1.prompt} \n");
        writeLoad = Console.ReadLine();
        

        }

    public void Display(){

        Console.WriteLine(entry2.loadList);
    }
    
}