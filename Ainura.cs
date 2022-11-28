using System.Collections.Generic;
using System.Diagnostics.Contracts;

class Ainura{
    private List<Table> _tables;
    private List<Table> _cleanTables;


    public Ainura(List<Table> dirtyTables, List<Table> cleanTables){
        _tables = dirtyTables;
        _cleanTables = cleanTables;
    }
    private void CheckTables(){
        while (_tables.Count > 0)
        {
            CleanUp();
        }
    }
    public void CleanUp()
    {
        Contract.Requires(_tables.Count > 0);
        Table temp = _tables[0];
        _cleanTables.Add(temp);
        _cleanTables.RemoveAt(0);
    }
}
