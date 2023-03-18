using System;

class Outdoor : Event{
    private string _weather, _oType;

    public Outdoor(string title, string description, string address, string date, string time, string weather, string oType)
        : base(title, description, address, date, time){
            _weather = weather;
            _oType = oType;
    }

    public string GetWeather(){
        return $"Event Type: {_oType}\nWeather: {_weather}";
    }
    public string ShortOutdoor(){
        return $"Type: {_oType}";
    }
}