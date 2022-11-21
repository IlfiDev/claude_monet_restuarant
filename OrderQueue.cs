using System.Collections.Generic;

class OrderQueue{

    public List<string> Orders;
    public List<string> PreparedOrders;
    

    public void AddOrder(string order){
        Orders.Add(order);
    }

    public string GetOrder(){
        string orderToCook = Orders[0];
        Orders.RemoveAt(0);
        return orderToCook;
    }

    public string GetPreparedOrder(){
        string itemToServe = PreparedOrders[0];
        PreparedOrders.RemoveAt(0);
        return itemToServe;
    }
    public void AddPreparedOrder(string order){
        PreparedOrders.Add(order);
    }
}
