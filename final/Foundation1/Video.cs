using System;

public class Video{
    public string _title, _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>{};

    public void DisplayVideo(){
        Console.WriteLine("Video \n---------------------------------------------");
        Console.WriteLine($"\nVideo Title: {_title} \nAuthor: {_author} \nVideo Length: {_length} Seconds\n");
        Console.WriteLine("Comments \n--------------------------------------------- ");

        foreach(Comment com in _comments){
            com.DisplayComment();
        }

}
}