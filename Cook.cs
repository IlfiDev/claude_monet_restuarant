class Cook{

    private OrderQueue _queue;
    private String _order = "";
    private String _preparedOrder = "";

    public Cook(OrderQueue queue){
        _queue = queue;
    }

    public void GetOrder(string order){
        if(_order != ""){
            _order = _queue.GetOrder();
        }
    }

    private void cook(){
        Thread.Sleep(300);

        _preparedOrder = _order;
        _order = "";
        _queue.AddPreparedOrder(_preparedOrder);

    }

}
