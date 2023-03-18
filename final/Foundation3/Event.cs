using System;

public class Event{
    private string _title, _description, _address, _date, _time;
    
    
    public Event(string title, string description, string address, string date, string time){
        _title = title;
        _description = description;
        _address = address;
        _date = date;
        _time = time;
    }

    public string GetTitle(){
        return _title;
    }
    public string GetDescription(){
        return _description;
    }
    public string GetAddress(){
        return _address;
    }

    public string StandardDetials(){
        return $"Title: {_title}\nDescription: {_description}\nAddress: {_address}\nDate: {_date}\nTime: {_time}";
    }

    public string ShortDetails(){
        return $"Title: {_title}\nDate: {_date}";
    }
   

    
}