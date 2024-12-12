class Car
{
    public int Passengers;
    public int ContrabandAmount;
    public bool AlreadyChecked = false;



//checks if  car has contraband or not
    public bool Examine()
    {
        AlreadyChecked = true;
        int EscapeOdd = (5 - ContrabandAmount) / 10;
        int r = Random.Shared.Next(1, 11);

        //if u are unlucky, contraband car might still escape
        if (EscapeOdd >= r)
        {
            return false;
        }

        //if car didnt escape, then we check if it has contraband, if it does, return true
        if (ContrabandAmount > 0)
        {
            return true;
        }
        return false;
    }
}


class CleanCar : Car
{
    //creates a car without contraband
    public CleanCar()
    {
        Passengers = Random.Shared.Next(1, 4);
        ContrabandAmount = 0;
    }


}
class ContrabandCar : Car
{
    //creates car with contraband
    public ContrabandCar()
    {
        Passengers = Random.Shared.Next(1, 5);
        ContrabandAmount = Random.Shared.Next(1, 5);
    }



}