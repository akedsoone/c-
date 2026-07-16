Console.WriteLine("Циклы");
Console.WriteLine("1 Необходимо вывести на экран числа от N до 1.");
Console.WriteLine("2 Необходимо, чтоб программа выводила на экран вот такую последовательность : 7 14 21 28 42 49….");
Console.WriteLine("3 Вывод последовательности Фибоначчи");

int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Необходимо вывести на экран числа от N до 1.");

        Console.WriteLine("Введите число N");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваши числа:");


        for (int i = 1; i <= N; i++)
        {
            Console.Write(i);
            Console.Write(" ");

        }

        break;

    case 2:
        Console.WriteLine("Необходимо, чтоб программа выводила на экран вот такую последовательность : 7 14 21 28 42 49….");

        for(int i = 1; i<=10; i++)
        {
            int n = i * 7;
            Console.Write(n);
            Console.Write(" ");
        }

        break;

    case 3:
        Console.WriteLine("Вывод последовательности Фибоначчи");
        break;

    default:
        Console.WriteLine("Выбери задание от 1 до 3.");
        break;
}
