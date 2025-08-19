using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();

        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Добавить число");
            Console.WriteLine("2. Добавить слово и число в словарь");
            Console.WriteLine("3. Удалить число");
            Console.WriteLine("4. Удалить слово из словаря");
            Console.WriteLine("5. Показать числа");
            Console.WriteLine("6. Показать словарь");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Введите число: ");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        numbers.Add(number);
                        Console.WriteLine("Число добавлено.");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод.");
                    }
                    break;

                case "2":
                    Console.Write("Введите слово: ");
                    string word = Console.ReadLine();
                    Console.Write("Введите число: ");
                    if (int.TryParse(Console.ReadLine(), out int numberForWord))
                    {
                        if (!wordsDictionary.ContainsKey(word))
                        {
                            wordsDictionary.Add(word, numberForWord);
                            Console.WriteLine("Слово и число добавлены в словарь.");
                        }
                        else
                        {
                            Console.WriteLine("Слово уже существует в словаре.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод.");
                    }
                    break;

                case "3":
                    Console.Write("Введите число для удаления: ");
                    if (int.TryParse(Console.ReadLine(), out int numberToRemove))
                    {
                        if (numbers.Remove(numberToRemove))
                        {
                            Console.WriteLine("Число удалено.");
                        }
                        else
                        {
                            Console.WriteLine("Число не найдено.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод.");
                    }
                    break;

                case "4":
                    Console.Write("Введите слово для удаления: ");
                    string wordToRemove = Console.ReadLine();
                    if (wordsDictionary.Remove(wordToRemove))
                    {
                        Console.WriteLine("Слово удалено из словаря.");
                    }
                    else
                    {
                        Console.WriteLine("Слово не найдено в словаре.");
                    }
                    break;

                case "5":
                    Console.WriteLine("Список чисел:");
                    foreach (var num in numbers)
                    {
                        Console.WriteLine(num);
                    }
                    break;

                case "6":
                    Console.WriteLine("Словарь:");
                    foreach (var entry in wordsDictionary)
                    {
                        Console.WriteLine($"Слово: {entry.Key}, Число: {entry.Value}");
                    }
                    break;

                case "0":
                    Console.WriteLine("Выход из программы.");
                    return;

                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}
