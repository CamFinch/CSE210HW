using System;

public class Product{
    private string _productName;

    private int _productId, _quantity, _price;

    public Product(string productName, int productId, int quantity, int price){
        _productName = productName;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }
    
    public int TotalPrice(){
      int total = _price * _quantity;
      return total;
    }

    public string ProductName(){
      return _productName;
    }

    public int ProductId(){
      return _productId;
    }

    public int ProductQuantity(){
      return _quantity;
    }

    public int ProductPrice(){
      return _price;
    }

    

    

}