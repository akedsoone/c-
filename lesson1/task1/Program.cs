Console.WriteLine("ЗАПОЛНЕНИЕ АНКЕТЫ");
Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.Write("Введите ваш возраст: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ваш рост (в метрах, например 1,75): ");
decimal heigh = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("ВАША КАРТОЧКА");
Console.WriteLine($"Имя: {name}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Рост: {heigh}");
Console.WriteLine("Примерный год рождения: " + (2026 - age));