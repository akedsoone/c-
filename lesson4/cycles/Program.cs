do
{
    Console.WriteLine("Циклы, матрицы");
    Console.WriteLine("1 Необходимо вывести на экран числа от N до 1.");
    Console.WriteLine("2 Необходимо, чтоб программа выводила на экран вот такую последовательность : 7 14 21 28 42 49….");
    Console.WriteLine("3 Вывод последовательности Фибоначчи");
    Console.WriteLine("4 Создать матрицу");
    Console.WriteLine("5 Выход из программы");

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
                int a = i * 7;
                Console.Write(a);
                Console.Write(" ");
            }
            Console.WriteLine("\n");

            break;

        case 3:
            Console.WriteLine("Вывод последовательности Фибоначчи");

            List<int> list = [];

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
                int b = list[i - 1] + list[i - 2];
                list.Add(b);
                Console.Write($"{b} ");

            }
            Console.WriteLine("\n");

            break;

        case 4:
            Console.WriteLine("Введите количество строк в матрице (не более 6):");
          
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0 && n <= 6)
            {
                
            }
            else
            {
                Console.WriteLine("Ошибка, введите число от 1 до 6.");
                return;
            }

            Console.WriteLine("Введите количество столбцов в матрице (не более 6):");

            if (int.TryParse(Console.ReadLine(), out int m) && m > 0 && m <= 6)
            {

            }
            else
            {
                Console.WriteLine("Ошибка, введите число от 1 до 6.");
                return;
            }


            int[,] arr = new int[n, m];

            Random rnd = new();

            Console.WriteLine();
            Console.WriteLine("Матрица:");

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(-9, 9);
                    Console.Write("|");
                    Console.Write(string.Format("{0,5}", arr[i, j]));
                    
                }

                Console.Write("|");
                Console.WriteLine();
            }

            int countM = 0;
            int countP = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] < 0)
                    {
                        countM++;
                    } 
                    else if (arr[i, j] > 0)
                    {
                        countP++;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"Отрицательные значения: {countM} \nПоложительные значения: {countP}");
            Console.WriteLine("");
            Console.WriteLine("Вывод матрицы (в нечетных строках только нечетные значения, в четных - только четные");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i % 2 != 0)
                    {
                        if(arr[i, j] % 2 != 0)
                        {
                            Console.Write("|");
                            Console.Write(string.Format("{0,5}", arr[i, j]));
                        }
                        else
                        {
                            Console.Write("|");
                            Console.Write(string.Format("{0,5}", 0));
                        }

                    }
                    else if (i % 2 == 0)
                    {
                        if (arr[i, j] % 2 == 0)
                        {
                            Console.Write("|");
                            Console.Write(string.Format("{0,5}", arr[i, j]));
                        }
                        else
                        {
                            Console.Write("|");
                            Console.Write(string.Format("{0,5}", 0));
                        }
                    }
                }
                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            break;

        case 5:
            return;

        default:
            Console.WriteLine("Выбери задание от 1 до 5.");
            Console.WriteLine("\n");

            break;
    }
} while (true);
