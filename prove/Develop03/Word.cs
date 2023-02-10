using System;
using System.IO;

public class Word{
    public int randomNumber;
    public string joined;
    // 5        2     3      4      4       3       5        6       3         4      3       4      5        3        14
    // 0       1     2       3      4       5       6       7          8       9      10     11     12        13      14
    //Trust", "in", "the", "Lord", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine", "own", "understanding."
    List<string> shownText = new List<string>{"Trust", "in", "the", "Lord", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine", "own", "understanding."};


    public void Hide(){
        Random random = new Random();
        Random random2 = new Random();
        int randomNumber = random.Next(0, shownText.Count);
        int randomNumber2 = random2.Next(0, shownText.Count);
        int numLetter = shownText[randomNumber].Length;
        if(shownText[randomNumber] != "--" || shownText[randomNumber] != "---" || shownText[randomNumber] != "----" || shownText[randomNumber] != "-----" || shownText[randomNumber] != "------" || shownText[randomNumber] != "--------------" ){
            if(numLetter == 2){
  
                shownText.RemoveAt(randomNumber);
                shownText.Insert(randomNumber, "--");
            }
            else if(numLetter == 3){
 
                shownText.RemoveAt(randomNumber);
                shownText.Insert(randomNumber, "---");

            }
            else if(numLetter == 4){
                shownText.RemoveAt(randomNumber);
                shownText.Insert(randomNumber, "----");
        
            }
            else if(numLetter == 5){
                shownText.RemoveAt(randomNumber);
                shownText.Insert(randomNumber, "-----");
           
            }
            else if(numLetter == 6){
            
                shownText.RemoveAt(randomNumber);
                shownText.Insert(randomNumber, "------");  
            }
            else if(numLetter == 14){
            
                shownText.RemoveAt(randomNumber);
                shownText.Insert(randomNumber, "-------------");

            }
        }
        else{
            Hide();
        }
        
    }

    public void WriteText(){
        string joined = string.Join(" ", shownText);
        Console.WriteLine(joined);
        if(shownText[0] == "-----" && shownText[1] == "--" && shownText[2] == "---" && shownText[3] == "----" && shownText[4] == "----" && shownText[5] == "---" && shownText[6] == "-----" && shownText[7] == "------" && shownText[8] == "---" && shownText[9] == "----" && shownText[10] == "---" && shownText[11] == "----" && shownText[12] == "-----" && shownText[13] == "---" && shownText[14] == "-------------" ){
            System.Environment.Exit(0);
        }
    }

    
    
}