using System;
using System.IO;


class Entry
{
    public string filePath, journalEntry, newFileName, fileName, loadList;

    
    PromptGen promptgen1 = new PromptGen();
    DateTime date = DateTime.Now;
    Journal journal2 = new Journal();
   

    
    public void Save(){

        Console.WriteLine("What Would you Like to name the file to be saved to?");
        string newFileName = Console.ReadLine();

        
        using (StreamWriter outputFile = new StreamWriter(newFileName)){
            outputFile.WriteLine($"{date} \nPrompt: {promptgen1.prompt} \n{journal2.writeLoad}");

       
    }
    }

    public void Load(){

    Console.WriteLine("Enter File To Load From: ");
    string fileName = Console.ReadLine();

    List<string> lines = System.IO.File.ReadAllLines(fileName).ToList();

    foreach(string line in lines)
    {
        loadList = line;
    }  


    }
    
}