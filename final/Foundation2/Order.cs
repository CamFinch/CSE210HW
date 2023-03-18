using System;

public class Order{


    public List<Product> _products = new List<Product>();

    public List<Customer> _customer = new List<Customer>();
    Customer c1 = new Customer("Cameron Finch");
    
    public int TotalCost(){
        int totalCost = 0;
        foreach(Product p in _products){
            totalCost += p.TotalPrice();
        }
        if(c1.InUSA()){
            totalCost += 5;
        }
        else{
            totalCost += 35;
        }
        return totalCost;
        
    }

    public string PackingLabel(){
        string packingLabel = "";

        foreach(Product p in _products){
            packingLabel = $"{p.ProductName}\n{p.ProductId}\n{p.ProductQuantity}";
        }
        return packingLabel;
    }

    public string ShippingLabel(){
        string shippingLabel = "";
        
        shippingLabel = $"{c1.CustomerName}\n{c1.CustomerAddress}";
        
        return shippingLabel;
    }
}