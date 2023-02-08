using System;
using System.IO;

public class Reference{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    
    
    public Reference(string book, string chapter, string verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }
    public Reference(string book, string chapter, string verse, string endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;

    }

    public string WriteReference(){
        string writeRef = $"{_book} {_chapter}: {_verse}";
        return writeRef;
    }

    public string WriteRef2(){
        string writeRef2 = $"{_book} {_chapter}: {_verse} /n{_endVerse}";
        return writeRef2;
    }

}