int number = 0;
int qestion = 0;
bool qw = true;
do
{
    Console.WriteLine("КАЛЬКУЛЯТОР");
    Console.WriteLine("Выберите операцию:");
    Console.WriteLine("1 Сложение");
    Console.WriteLine("2 Вычитание");
    Console.WriteLine("3 Деление");
    Console.WriteLine("4 Умножение");
    Console.WriteLine("5 Процент от числа");
    Console.WriteLine("6 Квадратный корень числа");
    Console.WriteLine("7 Отображение результата");

    number = Convert.ToInt32(Console.ReadLine());

    switch (number)
    {
        case 1:
            Console.WriteLine("Введите первое число для сложения:");
            int additionA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для сложения:");
            int AddititonB = Convert.ToInt32(Console.ReadLine());
            int addition = additionA + AddititonB;
            Console.WriteLine($"Результат: {addition}");
            break;

        case 2:
            Console.WriteLine("Введите первое число для вычитания:");
            int subtractionA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для вычитания:");
            int subtractionB = Convert.ToInt32(Console.ReadLine());
            int subtraction = subtractionA - subtractionB;
            Console.WriteLine($"Результат: {subtraction}");
            break;

        case 3:
            Console.WriteLine("Введите первое число для деления:");
            int divisionA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для деления:");
            int divisionB = Convert.ToInt32(Console.ReadLine());
            int division = divisionA / divisionB;
            Console.WriteLine($"Результат: {division}");
            break;

        case 4:
            Console.WriteLine("Введите первое число для умножения:");
            int multiplicationA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для умножения:");
            int multiplicationB = Convert.ToInt32(Console.ReadLine());
            int multiplication = multiplicationA * multiplicationB;
            Console.WriteLine($"Результат: {multiplication}");
            break;

        case 5:
            Console.WriteLine("Введите число, от которого хотите найти процент:");
            int percentA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число, для которого хотите найти процент:");
            int percentB = Convert.ToInt32(Console.ReadLine());
            int percent = (percentB * 100) / percentA;
            Console.WriteLine($"Результат: {percent}");
            break;

        case 6:
            Console.WriteLine("Введите число, от которого хотите получить квадратный корень:");
            int squareA = Convert.ToInt32(Console.ReadLine());
            int square = squareA * squareA;
            Console.WriteLine($"Результат: {square}");
            break;

        case 7:
            Console.WriteLine("Результат:");
            break;

        default:
            Console.WriteLine("Ввудите число от 1 до 7!");
            break;
    }
    Console.WriteLine("Желаете продолжить? (да/нет)");
    var al = (Console.ReadLine());
    if (al == "нет")
    {
        return;
    }
}

while (qw);


