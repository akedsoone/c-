interface IVehicle
{
    void Drive(int distance);
    bool Refuel(int petrol);
}

abstract class Car : IVehicle
{
    protected int start;
    protected int run;

    public Car(int start, int run)
    {
        this.start = start;
        this.run = run;
    }

    public void Drive(int distance)
    {
        if(start > 0)
        {
            Console.WriteLine("Бензина больше 0");
            start = start - distance * run;
        } else {
            Console.WriteLine("Безниза нет");
        }
    }

    public bool Refuel(int petrol)
    {
        start = start + petrol;
        return true;
    }
}

class SportsCar : Car
{
    public SportsCar(int start, int run) : base(start, run) { }
}

class Truck : Car
{
    public Truck(int start, int run) : base(start, run) { }
}

class MAIN
{
    public static void Main(string[] args)
    {
        SportsCar car = new SportsCar(0, 0);

        Console.WriteLine("Введите количество бензина для заправки:");
        int petrol = Convert.ToInt32(Console.ReadLine());

        car.Refuel(petrol);
        car.Drive(5);

        Console.ReadLine();
    }
}