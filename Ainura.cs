using System.Collections.Generic;
using System.Diagnostics.Contracts;

class Ainura{
    private List<Table> _tables;
    private List<Table> _cleanTables;
    private void CheckTables(){
        while (_tables.Count > 0)
        {
            CleanUp();
        }
    }
    public void CleanUp()
    {
        Contract.Requires(table != null);
        Table temp = _tables[0];
        _cleanTables.Add(temp);
        _cleanTables.Remove(0);
    }
}
