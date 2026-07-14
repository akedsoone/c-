using System.ComponentModel.Design;

int number = 0;
bool qw = true;
var al = "";

double addition = 0;
double additionn = 0;
double additionA = 0;
double additionB = 0;

double subtraction = 0;
double subtractionn = 0;
double subtractionA = 0;
double subtractionB = 0;

double division = 0;
double divisionn = 0;
double divisionA = 0;
double divisionB = 0;

double multiplication = 0;
double multiplicationn = 0;
double multiplicationA = 0;
double multiplicationB = 0;

double percent = 0;
double percentt = 0;
double percentA = 0;
double percentB = 0;

double square = 0;
double squaree = 0;
double squareA = 0;

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

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Ошибка, введите целое число!");
    }

    switch (number)
    {
        case 1:
            Console.WriteLine("Введите первое число для сложения:");
            while (!double.TryParse(Console.ReadLine(), out additionA))
            {
                Console.WriteLine("Ошибка, введите число! (Например 4; 3,5)");
            }
            Console.WriteLine("Введите второе число для сложения:");
            while (!double.TryParse(Console.ReadLine(), out additionB))
            {
                Console.WriteLine("Ошибка, введите число! (Например 4; 3,5)");
            }
            addition = additionA + additionB;
            additionn = Math.Round(addition, 2);
            Console.WriteLine($"Результат: {additionn}");
            break;

        case 2:
            Console.WriteLine("Введите первое число для вычитания:");
            while (!double.TryParse(Console.ReadLine(), out subtractionA))
            {
                Console.WriteLine("Ошибка, введите число! (Например 4; 3,5)");
            }
            Console.WriteLine("Введите второе число для вычитания:");
            while (!double.TryParse(Console.ReadLine(), out subtractionB))
            {
                Console.WriteLine("Ошибка, введите число! (Например 4; 3,5)");
            }
            subtraction = subtractionA - subtractionB;
            subtractionn = Math.Round(subtraction, 2);
            Console.WriteLine($"Результат: {subtractionn}");
            break;

        case 3:
            Console.WriteLine("Введите первое число для деления:");
            while (!double.TryParse(Console.ReadLine(), out divisionA))
            {
                Console.WriteLine("Ошибка, введите число! (Например 4; 3,5)");
            }
            Console.WriteLine("Введите второе число для деления:");
            while (!double.TryParse(Console.ReadLine(), out divisionB))
            {
                Console.WriteLine("Ошибка, введите число! (Например 4; 3,5)");
            }
            division = divisionA / divisionB;
            divisionn = Math.Round(division, 2);
            Console.WriteLine($"Результат: {divisionn}");
            break;

        case 4:
            Console.WriteLine("Введите первое число для умножения:");
            while (!double.TryParse(Console.ReadLine(), out multiplicationA))
            {
                Console.WriteLine("Ошибка, введите число! (Например 4; 3,5)");
            }
            Console.WriteLine("Введите второе число для умножения:");
            while (!double.TryParse(Console.ReadLine(), out multiplicationB))
            {
                Console.WriteLine("Ошибка, введите число! (Например 4; 3,5)");
            }
            multiplication = multiplicationA * multiplicationB;
            multiplicationn = Math.Round(multiplication, 2);
            Console.WriteLine($"Результат: {multiplicationn}");
            break;

        case 5:
            Console.WriteLine("Введите число, от которого хотите найти процент:");
            while (!double.TryParse(Console.ReadLine(), out percentA))
            {
                Console.WriteLine("Ошибка, введите число! (Например 4; 3,5)");
            }
            Console.WriteLine("Введите число, для которого хотите найти процент:");
            while (!double.TryParse(Console.ReadLine(), out percentB))
            {
                Console.WriteLine("Ошибка, введите число! (Например 4; 3,5)");
            }
            percent = (percentB * 100) / percentA;
            percentt = Math.Round(percent, 2);
            Console.WriteLine($"Результат: {percentt}");
            break;

        case 6:
            Console.WriteLine("Введите число, от которого хотите получить квадратный корень:");
            while (!double.TryParse(Console.ReadLine(), out squareA))
            {
                Console.WriteLine("Ошибка, введите число! (Например 4; 3,5)");
            }
            square = squareA * squareA;
            squaree = Math.Round(square, 2);
            Console.WriteLine($"Результат: {squaree}");
            break;

        case 7:
            if (addition != 0)
            {
                Console.WriteLine($"Результат последнего сложения {additionA} и {additionB}: {additionn}");
            }
            if (subtraction != 0)
            {
                Console.WriteLine($"Результат последнего вычитания {subtractionB} от {subtractionA}: {subtractionn}");
            }
            if (division != 0)
            {
                Console.WriteLine($"Результат последнего деления {divisionA} на {divisionB}: {divisionn}"); 
            }
            if (multiplication != 0)
            {
                Console.WriteLine($"Результат последнего умножения {multiplicationA} на {multiplicationB}: {multiplicationn}");
            }
            if (percent != 0)
            {
                Console.WriteLine($"Результат последнего нахождения процента {percentB} от {percentA}: {percentt}");
            }
            if (square != 0)
            {
                Console.WriteLine($"Результат последнего нахождения квадрата числа {squareA}: {squaree}");
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
        
        if (al == "да" || al == "Да" || al == "Д" || al == "д"|| al == "y" || al == "Y" || al == "yes" || al == "Yes")
        {
            continue;
        }
        else if (al == "нет" || al == "Нет" || al == "Н" || al == "н" || al == "N" || al == "n" || al == "No" || al == "no")
        {
            return;
        }
        else
        {
            Console.WriteLine("Напишите да или нет.");
           
        }
    } while (al != "да");
    
} while (qw);


