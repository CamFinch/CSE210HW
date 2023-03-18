using System;

public class Comment{
    public string _username, _message;

    
    public void DisplayComment(){
        Console.WriteLine($"Username: {_username} \nMessage: {_message}");
    }
}