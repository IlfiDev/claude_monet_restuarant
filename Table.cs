class Table{
    private Visitor status;
    public void SetVisitor(Visitor visitor){
        status = visitor;
    }
    public Visitor GetVisitor(){
        return status;
    }
}