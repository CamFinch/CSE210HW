using System;

public class Customer{
    private string _name;
    private Address _address;

    public Customer(string name){
        _name = name;
    }

    public string CustomerName(){
        return _name;
    }
    public Address CustomerAddress(){
        return _address;
    }

    public bool InUSA(){
       return _address.USA();
    }

}