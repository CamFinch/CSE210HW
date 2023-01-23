using System;
using System.IO;


public class Entry
{
    public string filePath;
    public string journalEntry;

    public string newFileName;

    public string fileName;
    
    

    PromptGen promptgen1 = new PromptGen();
    DateTime date = DateTime.Now;
   

    
    public void EntryAndSave(){

        Console.WriteLine("What Would you Like to name the file to be saved to?");
        string newFileName = Console.ReadLine();

        

        Console.WriteLine($"Prompt: {promptgen1.prompt}");
        string journalEntry = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(newFileName)){
            outputFile.WriteLine($"{date} \nPrompt: \n{journalEntry}");

       


    }
    }

    public void Load(){

    Console.WriteLine("Enter File To Load From: ");
    string fileName = Console.ReadLine();


    
    List<string> lines = System.IO.File.ReadAllLines(fileName).ToList();

    foreach(string s in lines)
{
    Console.WriteLine(s);
}  
    


    }
    
}