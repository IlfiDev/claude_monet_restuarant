using System.Diagnostics.Contracts;
using System.Collections.Generic;

class Visitor {

    List<Table> FreeTables;
    List<Table> BusyTabels;
    List<Table> ReadyToOrder;
    List<Table> ReadyToLeave;
    private String order = "";
    

    public Visitor(List<Table> freeTables, List<Table> busyTabels, List<Table> readyToOrder, List<Table> readyToLeave) {
        FreeTables = freeTables;
        BusyTabels = busyTabels;
        ReadyToOrder = readyToOrder;
        ReadyToLeave = readyToLeave;

        if(freeTables.Count > 0) {
            Table table = freeTables[0];
            freeTables.Remove(table);

            busyTabels.Add(table);

        } else {

            Task.Run(tryToDetAnotherPlace);
        }
    }

    async private void tryToDetAnotherPlace() {
        await Task.Delay(5000);

        if(FreeTables.Count > 0) {
            Table table = FreeTables[0];
            FreeTables.Remove(table);

            BusyTabels.Add(table);

        } else {
            Task.Run(tryToDetAnotherPlace);
        }
    }


    public bool MakeOrder() {
        Random random = new Random();
        int temp_int = random.Next(100);
        if(temp_int <= 25) {
            return true;
        } else {
            return false;
        }
    }

    public bool ReadyToLeaveRestuarant() {
        Random random = new Random();
        int temp_int = random.Next(100);
        if(temp_int <= 35) {
            return true;
        } else {
            return false;
        }
    }

    public String GetOrder() {
        Contract.Ensures(order != null);
        return order;
    }

    public void GiveOrder(string order) {
        Thread.Sleep(50);
        ReadyToLeaveRestuarant();
    }

}
