using System.Collections.Generic;

class Waiter{
    public OrderQueue orders;
    public List<Table> readyToOrderTable;
    public string order;
    public Waiter(List<Table> tables, OrderQueue _orders)
    {
        readyToOrderTable = tables;
        orders = _orders;
    }

    public void TakeOrder(){
        foreach (Table table in readyToOrderTable)
        {
            order = table.GetVisitor().GetOrder();
            orders.AddOrder(order);
        }
    }

    public void GiveOrder(){
        foreach (Table table in readyToOrderTable)
        {
            order = orders.GetPreparedOrder();

            if (table.Equals(order)){
                table.GetVisitor().GiveOrder(order);
            }
        }
    }
}