using System;
using System.IO;

public class Word{
    public int randomNumber;
    public string joined;
    
    
    //Trust", "in", "the", "Lord", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine", "own", "understanding."
    List<string> shownText = new List<string>{"Trust", "in", "the", "Lord", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine", "own", "understanding."};


    public void Hide(){
        Random random = new Random();
        Random random2 = new Random();
        int randomNumber = random.Next(0, shownText.Count);
        int randomNumber2 = random2.Next(0, shownText.Count);
        int numLetter = shownText[randomNumber].Length;
        if(numLetter == 3){
            if(shownText[randomNumber] != "---"){
                shownText.RemoveAt(randomNumber);
                shownText.Insert(randomNumber, "---");
                shownText.RemoveAt(randomNumber2);
                shownText.Insert(randomNumber2, "---");
            }
            else{
                Hide();
            }
        }
        if(numLetter == 4){
            if(shownText[randomNumber] != "----"){
                shownText.RemoveAt(randomNumber);
                shownText.Insert(randomNumber, "----");
                shownText.RemoveAt(randomNumber2);
                shownText.Insert(randomNumber2, "----");
            }
            else{
                Hide();
            }
        }
        if(numLetter == 5){
            if(shownText[randomNumber] != "-----"){
                shownText.RemoveAt(randomNumber);
                shownText.Insert(randomNumber, "-----");
                shownText.RemoveAt(randomNumber2);
                shownText.Insert(randomNumber2, "-----");
            }
            else{
                Hide();
            }
        }
        if(numLetter == 6){
            if(shownText[randomNumber] != "------"){
                shownText.RemoveAt(randomNumber);
                shownText.Insert(randomNumber, "------");
                shownText.RemoveAt(randomNumber2);
                shownText.Insert(randomNumber2, "------");
            }
            else{
                Hide();
            }
        }

        
    }

    public void WriteText(){
        string joined = string.Join(" ", shownText);
        Console.WriteLine(joined);
        if(shownText[0] == "---" && shownText[1] == "---" && shownText[2] == "---" && shownText[3] == "---" && shownText[4] == "---" && shownText[5] == "---" && shownText[6] == "---" && shownText[7] == "---" && shownText[8] == "---" && shownText[9] == "---" && shownText[10] == "---" && shownText[11] == "---" && shownText[12] == "---" && shownText[13] == "---" && shownText[14] == "---" ){
            System.Environment.Exit(0);
        }
    }

    
    
}