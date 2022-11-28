using System.Diagnostics.Contracts;
class Table{
    private Visitor status;
    public Table(){}
    public void SetVisitor(Visitor visitor){
        Contract.Requires(visitor != null);
        status = visitor;
    }
    public Visitor GetVisitor(){
        return status;
    }
}
