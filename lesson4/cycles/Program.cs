do
{
    Console.WriteLine("Циклы");
    Console.WriteLine("1 Необходимо вывести на экран числа от N до 1.");
    Console.WriteLine("2 Необходимо, чтоб программа выводила на экран вот такую последовательность : 7 14 21 28 42 49….");
    Console.WriteLine("3 Вывод последовательности Фибоначчи");
    Console.WriteLine("4 Выход из программы");

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
            Console.WriteLine("\n");

            break;

        case 2:
            Console.WriteLine("Необходимо, чтоб программа выводила на экран вот такую последовательность : 7 14 21 28 42 49….");

            Console.WriteLine("Введите число N");
            int N2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N2; i++)
            {
                int n = i * 7;
                Console.Write(n);
                Console.Write(" ");
            }
            Console.WriteLine("\n");

            break;

        case 3:
            Console.WriteLine("Вывод последовательности Фибоначчи");

            List<int> list = new();

            Console.WriteLine("Введите число N");
            int N3 = Convert.ToInt32(Console.ReadLine()) - 1;


            for (int i = 0; i <= N3; i++)
            {
                if (i == 0 || i == 1)
                {
                    Console.Write($"{i} ");
                    list.Add(i);
                    continue;
                }
                int n = list[i - 1] + list[i - 2];
                list.Add(n);
                Console.Write($"{n} ");

            }
            Console.WriteLine("\n");

            break;

        case 4:
            return;

        default:
            Console.WriteLine("Выбери задание от 1 до 3.");
            Console.WriteLine("\n");

            break;
    }
} while (true);
