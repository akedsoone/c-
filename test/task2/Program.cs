class Person
{
    public int age;

    public void Greet()
    {
        Console.WriteLine("Здравствуйте");
    }

    public void SetAge(int age)
    {
        this.age = age;
    }
}

class Student : Person
{
    public void Study()
    {
        Console.WriteLine("Я учусь");
    }

    public void ShowAge()
    {
        Console.WriteLine($"Мой возраст: {age} лет");
    }
}

class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("Я объясняю");
    }
}

class StudentProfessorTest
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.Greet();


        Student student = new Student();
        student.SetAge(20);
        student.Greet();
        student.ShowAge();

        Teacher teacher = new Teacher();
        teacher.SetAge(40);
        teacher.Greet();
        teacher.Explain();

        Console.ReadLine();
    }
}