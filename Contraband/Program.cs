Console.WriteLine("How many cars would you like to create?");
string answer1;
List<Car> cars = new List<Car>();
bool Input = false;
int AmountOfCars;

do
{
    //we check if the input user gives, is above 0, and is an integer, if not, this code block redo's
    Console.WriteLine("Must be a digit thats above 0");
    answer1 = Console.ReadLine() ?? "";
    int x;
    if (!int.TryParse(answer1, out x))
    {
        Input = false;
    }
    else
    {
        if (Convert.ToInt32(x) <= 0)
        {
            Input = false;
        }
        else
        {
            Input = true;
        }
    }
} while (Input == false);

AmountOfCars = Convert.ToInt32(answer1);

//Creates as many cars as user put in
for (int i = 0; i < AmountOfCars; i++)
{
    int r = Random.Shared.Next(1, 3);

    if (r == 1)
    {
        CleanCar car = new CleanCar();
        cars.Add(car);
    }
    else
    {
        ContrabandCar car = new ContrabandCar();
        cars.Add(car);
    }
}

Console.Clear();
Console.WriteLine("Time to examine the cars");

//for every car we have, we say if it has contraband or not
for (int i = 0; i < AmountOfCars; i++)
{
    Console.WriteLine($"Examining car {i+1}");
    bool temp = cars[i].Examine();
    if (temp == true)
    {
        Console.WriteLine("car had contraband");
    }
    else
    {
        Console.WriteLine("Car had no contraband, or escaped with it");
    }
    Console.WriteLine("\nPress any key to continue");
    Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("You examined all cars!");
Console.ReadLine();