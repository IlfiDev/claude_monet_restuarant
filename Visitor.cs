class Visitor {

/*
    public bool MakeOrder() {
        Random random = new Random();
        int temp_int = random.Next(100);
        if(temp_int <= 25) {
            return true;
        } else {
            return false;
        }
    }

    public bool ReadyToLeave() {
        Random random = new Random();
        int temp_int = random.Next(100);
        if(temp_int <= 35) {
            return true;
        } else {
            return false;
        }
    }
*/

    public bool MakeOrder() {
        return true;
    }

    public bool ReadyToLeave() {
        return true;
    }
}