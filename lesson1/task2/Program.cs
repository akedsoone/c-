Console.Write("Введите значение переменной а типа int: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение переменной b типа int: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ваши переменные: а = {a} и b = {b}.");

int c = a;
a = b;
b = c;

Console.Write($"Ваши переменные, поменяные местами: а = {a} и b = {b}");