using System;

public class Address{
    private string _streetAddress, _city, _state, _country;
    private bool _citizen;


    public Address(string streetAddress, string city, string state, string country){
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool USA(){

       return _country == "USA";
        
    }

    public string DisplayAddress(){
        string customerAddress = $"{_streetAddress}, {_city} \n{_state}, {_country}";
        return customerAddress;
    }

}