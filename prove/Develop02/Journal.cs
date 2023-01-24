using System;
using System.IO;

public class Journal
{

    public string fileName;
    public string journalEntry;
    public string choice;

    Entry entry1 = new Entry();



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
                i++;
                entry1.EntryAndSave();
        
            }
            else if (choice == "2"){
                //Display
                i++;
            
            }

            else if (choice == "3"){
                //Load
                i++;
                entry1.Load();
              
            }

            else if (choice == "4"){
                //Save
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


    public void WriteJournalFile(){

    

 
            
        }
    

    



    
}