string text = "Wow! This is my 1st tsest. Do you see number42? Yes! \r\nOtto ran to room101. Anna loves level99. \r\nAre you ready? No, I am not! \r\nThis sentence has no comma. But this one, definitely has a comma, right? \r\nHey! Look at Bob — he found 777 coins! \r\nIs 12345 the longest digit-word? Maybe! \r\nOtto said: \"Wow!\" Anna replied: \"Yes!\" \r\nFinal test. Done!";
Console.WriteLine(text);

int number = 0;

do
{
    Console.WriteLine("Символы и строки");
    Console.WriteLine("1 Найти слова, содержащие максимальное количество цифр");
    Console.WriteLine("2 Найти самое длинное слово и определить, сколько раз оно встретилось в тексте");
    Console.WriteLine("3 Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять»");
    Console.WriteLine("4 Вывести на экран сначала вопросительные, а затем восклицательные предложения");
    Console.WriteLine("5 Вывести на экран только предложения, не содержащие запятых");
    Console.WriteLine("6 Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву");
    Console.WriteLine("7 Добавить возможность поиска по части ввода. ( не учитывать регистр)");
    Console.WriteLine("8 Вывести палиндромы, если они есть");
    Console.WriteLine("0 Выйти");

    number = Convert.ToInt32(Console.ReadLine());

    switch (number)
    {
        case 0:
            return;

        case 1:

            break;
        case 2:

            break;

        case 3:

            break;

        case 4:

            break;

        case 5:

            break;

        case 6:

            break;

        case 7:

            break;

        case 8:

            break;

        default:

            break;

    }


} while (number != 0);