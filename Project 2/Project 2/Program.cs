using System;
using System.Diagnostics.Metrics;
using System.Globalization;

class Program
{
    static void Main()
    {
        while (true)
        {
            int quantity;
            char bleba;
            Console.WriteLine("Какое количество строк вы желаете: ");
            if (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
            {
                Console.WriteLine("Пожалуйста введите целоцисленое положительное число:");
                continue;
            }
            string[] inputs = new string[quantity];
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Введите строку №" + (i + 1));
                inputs[i] = Console.ReadLine();
            }
            string combinedinputs = string.Join("", inputs);
            int totalCharacters = combinedinputs.Length; //общее количество символов 
            Console.WriteLine("Введите символ что хотите подсчитать: ");
            bleba = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < combinedinputs.Length; i++)
            {
                if (combinedinputs[i] == bleba)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество символов '{bleba}': {count}");
            Console.WriteLine("Хотите продолжить(да или нет): ");
            string con = Console.ReadLine();
            if (con.ToLower() != "да")
            {
                break;
            }
        }
    }
}
//Пользователя спрашивают, сколько строк он хочет ввести
//Пользователь вводит эти строки поочерёдно
//Программа объединяет их в одну строку, считает число символов
//Программа спрашивает, число каких символов в предложении посчитать (необходимо выполнить с помощью всех трех типов циклов в C#)
//Программа выводит его

// Сделано на for