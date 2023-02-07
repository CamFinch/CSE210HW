using System;
using System.IO;


public class Entry
{
    public DateTime _date = DateTime.Now;   
    public string _prompt;
    public string _response;
    //public string AddedEntry(){
        //string added = $"{_date} \n{_prompt}: \n{_response}";
        //return added;
    //}

    public void DisplayEntry(){
        Console.WriteLine($"{_date} \nPrompt: {_prompt} \n{_response}");
    }
    
}
