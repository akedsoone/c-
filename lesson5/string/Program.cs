using System.Text.RegularExpressions;

string text = "Wow! This is my 1st tsest. Do you see number42? Yes! \r\nOtto ran to room101. Anna loves level99. \r\nAre you ready? No, I am not! \r\nThis sentence has no comma. But this one, definitely has a comma, right? \r\nHey! Look at Bob — he found 777 coins! \r\nIs 12345 the longest digit-word? Maybe! \r\nOtto said: \"Wow!\" Anna replied: \"Yes!\" \r\nFinal test. Done!";
Console.WriteLine(text);
Console.WriteLine("\n");

int number = 0;

do
{
    Console.WriteLine("Символы и строки");
    Console.WriteLine("1 Вывести тукст");
    Console.WriteLine("2 Найти слова, содержащие максимальное количество цифр");
    Console.WriteLine("3 Найти самое длинное слово и определить, сколько раз оно встретилось в тексте");
    Console.WriteLine("4 Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять»");
    Console.WriteLine("5 Вывести на экран сначала вопросительные, а затем восклицательные предложения");
    Console.WriteLine("6 Вывести на экран только предложения, не содержащие запятых");
    Console.WriteLine("7 Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву");
    Console.WriteLine("8 Добавить возможность поиска по части ввода. ( не учитывать регистр)");
    Console.WriteLine("9 Вывести палиндромы, если они есть");
    Console.WriteLine("0 Выйти");

    List<string> wordsclean = new List<string>();
    string[] words = text.Split(' ');
    string wordclean = words[0];
    foreach (string word in words)
    {
        wordclean = word.Trim('!', '?', '.', ',', '-', '_', ':', ';', '(', ')', '\'', '"', '—');
        wordclean = Regex.Replace(wordclean, @"[\r\t\n]+", "");
        if (wordclean.Length > 0)
        {
            wordsclean.Add(wordclean);
        }
    }

    number = Convert.ToInt32(Console.ReadLine());

    switch (number)
    {
        case 0:

            return;

        case 1:
            foreach (string word in wordsclean)
            {
                Console.WriteLine(word);
            }

            break;
        case 2:
            int count = 0;
            int maxCount = 0;
            string maxWord = "";
            List<string> maxWords = new List<string>();
            foreach (string word in wordsclean)
            {
                foreach (char c in word)
                {
                    if (char.IsDigit(c))
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxWords.Clear();
                    maxWord = word;
                    maxWords.Add(maxWord);
                }
                else if (count == maxCount && count > 0)
                {
                    maxWords.Add(word);
                }
                count = 0;
            }

            Console.WriteLine("Максимально цифр: ");
            foreach (string max in maxWords)
            {
                Console.Write($"{max} "); 

            }
            Console.WriteLine("\n");
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

        case 9:

            break;

        default:

            break;

    }


} while (number != 0);