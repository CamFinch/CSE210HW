using System;

class Lecture : Event{
    private string _speakerName, _lType;
    private int _capacity;

    public Lecture(string title, string description, string address, string date, string time, string speakerName, int capacity, string lType)
        : base(title, description, address, date, time)
    {
        _speakerName = speakerName;
        _capacity = capacity;
        _lType = lType;
    }
    public string GetLectureInfo(){
        string cap = _capacity.ToString();
        return $"Event Type: {_lType}\nSpeaker: {_speakerName} \nCapacity: {cap}";
    }
    public string ShortLecture(){
        return $"Type: {_lType}";
    }

    
}