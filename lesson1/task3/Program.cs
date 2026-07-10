Console.WriteLine("КАЛЬКУЛЯТОР ПЛОЩАДИ И ПЕРИМЕТРА");

Console.Write("Введите ширину: ");
decimal width = Convert.ToDecimal(Console.ReadLine());

Console.Write("Введите длину: ");
decimal heigh = Convert.ToDecimal(Console.ReadLine());

Console.Write("Площадь: " + (width * heigh) + ". Периметр: " + (width + heigh) * 2);
