using System.ComponentModel.Design;

int number = 0;
bool qw = true;
var al = "";

int? addition = null;
var additionA = 0;
var additionB = 0;

int? subtraction = 0;
var subtractionA = 0;
var subtractionB = 0;

int? division = 0;
var divisionA = 0;
var divisionB = 0;

int? multiplication = 0;
int multiplicationA = 0;
int multiplicationB = 0;

int? percent = 0;
int percentA = 0;
int percentB = 0;

int? square = 0;
int squareA = 0;

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
            additionA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для сложения:");
            additionB = Convert.ToInt32(Console.ReadLine());
            addition = additionA + additionB;
            Console.WriteLine($"Результат: {addition}");
            break;

        case 2:
            Console.WriteLine("Введите первое число для вычитания:");
            subtractionA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для вычитания:");
            subtractionB = Convert.ToInt32(Console.ReadLine());
            subtraction = subtractionA - subtractionB;
            Console.WriteLine($"Результат: {subtraction}");
            break;

        case 3:
            Console.WriteLine("Введите первое число для деления:");
            divisionA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для деления:");
            divisionB = Convert.ToInt32(Console.ReadLine());
            division = divisionA / divisionB;
            Console.WriteLine($"Результат: {division}");
            break;

        case 4:
            Console.WriteLine("Введите первое число для умножения:");
            multiplicationA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для умножения:");
            multiplicationB = Convert.ToInt32(Console.ReadLine());
            multiplication = multiplicationA * multiplicationB;
            Console.WriteLine($"Результат: {multiplication}");
            break;

        case 5:
            Console.WriteLine("Введите число, от которого хотите найти процент:");
            percentA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число, для которого хотите найти процент:");
            percentB = Convert.ToInt32(Console.ReadLine());
            percent = (percentB * 100) / percentA;
            Console.WriteLine($"Результат: {percent}");
            break;

        case 6:
            Console.WriteLine("Введите число, от которого хотите получить квадратный корень:");
            squareA = Convert.ToInt32(Console.ReadLine());
            square = squareA * squareA;
            Console.WriteLine($"Результат: {square}");
            break;

        case 7:
            if (addition != 0)
            {
                Console.WriteLine($"Результат сложения {additionA} и {additionB}: {addition}");
            }
            if (subtraction != 0)
            {
                Console.WriteLine($"Результат вычитания {subtractionB} от {subtractionA}: {subtraction}");
            }
            if (division != 0)
            {
                Console.WriteLine($"Результат деления {divisionA} на {divisionB}: {division}"); 
            }
            if (multiplication != 0)
            {
                Console.WriteLine($"Результат умножения {multiplicationA} на {multiplicationB}: {multiplication}");
            }
            if (percent != 0)
            {
                Console.WriteLine($"Результат нахождения процента {percentB} от {percentA}: {percent}");
            }
            if (square != 0)
            {
                Console.WriteLine($"Результат нахождения квадрата числа {squareA}: {square}");
            }
            break;

        default:
            Console.WriteLine("Введите число от 1 до 7!");
            break;
    }

    do
    {
        Console.WriteLine("Желаете продолжить? (да/нет)");
        al = (Console.ReadLine());
        if (al == "да")
        {
            continue;
        }
        else if (al == "нет")
        {
            return;
        }
        else
        {
            Console.WriteLine("хуйню написал");
           
        }
    } while (al != "да");
    
} while (qw);


