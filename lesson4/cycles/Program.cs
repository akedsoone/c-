Console.WriteLine("Циклы");
Console.WriteLine("Необходимо вывести на экран числа от N до 1.");
Console.WriteLine("Необходимо, чтоб программа выводила на экран вот такую\r\nпоследовательность : 7 14 21 28 42 49….");
Console.WriteLine("Вывод последовательности Фибоначчи");

int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Необходимо вывести на экран числа от N до 1.");
        break;

    case 2:
        Console.WriteLine("Необходимо, чтоб программа выводила на экран вот такую\r\nпоследовательность : 7 14 21 28 42 49….");
        break;

    case 3:
        Console.WriteLine("Вывод последовательности Фибоначчи");
        break;

    default:
        Console.WriteLine("Выбери задание от 1 до 3.");
        break;
}
