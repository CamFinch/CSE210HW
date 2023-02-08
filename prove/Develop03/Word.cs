using System;
using System.IO;

public class Word{
    public int randomNumber;
    public string joined;
    
    
    //Trust", "in", "the", "Lord", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine", "own", "understanding."
    List<string> shownText = new List<string>{"Trust", "in", "the", "Lord", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine", "own", "understanding."};


    public void Hide(){
        Random random = new Random();
        int randomNumber = random.Next(0, shownText.Count);
        shownText.RemoveAt(randomNumber);
        shownText.Insert(randomNumber, "---");
        
    }

    public void WriteText(){
        string joined = string.Join(" ", shownText);
        Console.WriteLine(joined);
        
    }

    
    
}