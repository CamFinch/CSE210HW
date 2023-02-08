using System;
using System.IO;

public class Scripture{
    Reference reference1 = new Reference("Proverbs", "3", "5");
    Reference reference2 = new Reference("Proverbs", "3", "5", "6");
    Word word1 = new Word();
    public int i = 1;
    //public string textStr = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";

    public void Menu(){
        
            
        Word word1 = new Word();
        bool isActive = true;
            
        while(i == 1){
            Display();
            i++;
           
         }

        while(isActive){
            Console.WriteLine("\nPress Enter To Continue or Type EXIT to Exit: \n");
        
            var userEnter = Console.ReadLine();
            if(userEnter == ""){    
                word1.Hide();
                Console.Clear();
                Console.WriteLine(reference1.WriteReference());
                word1.WriteText();

                
            }
            else if(userEnter == "EXIT"){
                isActive = false;
            }
            else{
                Console.WriteLine("Incorrect Input: ");
                Menu();
            }
        }
    }

    public void Display(){
        Console.WriteLine(reference1.WriteReference());
        word1.WriteText();

    }

    //public string Text(){
        //string textStr = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        //return textStr;
    //}
    //public void DisplayNewText(){
       //List<string> NewText = new List<string>{word1.joined};
       //foreach(string line in NewText){
       // Console.WriteLine(line);
       //}
    //}
    


}