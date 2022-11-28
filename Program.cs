using System.Collections.Generic;

class Restuarant{
    

    static void Main(string[] args)
    {
        List<Table> emptyTables = new List<Table>();
        List<Table> occupiedTables = new List<Table>();
        List<Table> dirtyTables = new List<Table>();
        List<Table> someTables = new List<Table>();
        OrderQueue orderQueue= new OrderQueue();
        Waiter waiter = new Waiter(occupiedTables, orderQueue);

        for (int i = 0; i < 10; i++){
            emptyTables.Add(new Table());
        }
        Ainura ainura = new Ainura(dirtyTables, emptyTables);
        
        while(true){
            Visitor visitor = new Visitor(emptyTables, occupiedTables, dirtyTables, someTables);
            waiter.TakeOrder();
            waiter.GiveOrder();
            ainura.CheckTables();
        }
    }
        
}

