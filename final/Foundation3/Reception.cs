using System;

class Reception : Event{
    private string _email, _rType;

    public Reception(string title, string description, string address, string date, string time, string email, string rType)
        : base(title, description, address, date, time){
            _email = email;
            _rType = rType;
    }       
    public string GetEmail(){
        return $"Event Type: {_rType}\nEmail For RSVP: {_email}";
    }

    public string ShortReception(){
        return $"Type: {_rType}";
    }
}