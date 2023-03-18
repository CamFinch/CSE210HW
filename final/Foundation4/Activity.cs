using System;

public abstract class Activity{
    private string _date;
    private int _time;
    

    public Activity(string date, int time){
        _date = date;
        _time = time;
        
    }
    public void SetDate(string date){
        _date = date;
    }

    public string GetDate(){
        return _date;
    }

    public int GetTime(){
        return _time;
    }

    public void SetTime(int time){
        _time = time;
    }
    public abstract string GetSummary();

    
}