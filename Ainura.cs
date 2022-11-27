using System.Collections.Generic;

class Ainura{
    private List<Table> _tables;
    private void CheckTables(){
        foreach (Table table in _tables)
        {
            
        }
    }
    public void CleanUp(string clean){
        if(_tables != clean){
            this._tables = clean;
        }
    }
}
