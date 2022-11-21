class Cook{
    private String _order;
    private String _preparedOrder;
    public void GetOrder(string order){
        if(_order != null){
            this._order = order;
        }
    }

    private void cook(){
        _preparedOrder = _order;
        _order = null
    }

}
