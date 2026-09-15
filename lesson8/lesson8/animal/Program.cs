abstract class Animal
{
    public string Name { get; protected set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName() 
    {
        return Name;
    }

    public abstract void Eat();
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine($"Собака {Name} ест");
    }
}

class MAIN
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите имя собаки");
        string dogName = Console.ReadLine();
        Dog dog = new Dog();
        dog.SetName(dogName);
        Console.WriteLine("Имя собаки: " + dog.GetName());
        dog.Eat();
    }
}