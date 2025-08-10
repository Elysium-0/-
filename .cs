using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            double firstN, secondN;
            Console.WriteLine("Введите первое число: ");
            double.TryParse(Console.ReadLine(), out firstN);
            Console.WriteLine("Введите второе число: ");
            double.TryParse(Console.ReadLine(), out secondN);
            Console.WriteLine("Введите оператор (+, -, *, /): ");
            string Operator = Console.ReadLine();
            double res = 0;
            bool validOperation = true;

            switch (Operator)
            {
                case "+":
                    res = firstN + secondN;
                    break;
                case "-":
                    res = firstN - secondN;
                    break;
                case "*":
                    res = firstN * secondN;
                    break;
                case "/":
                    if (secondN == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль.");
                        validOperation = false;
                    }
                    else
                    {
                        res = firstN / secondN;
                    }
                    break;
                default:
                    Console.WriteLine("Неверный оператор.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Результат: {res}");
            }
            else
            {
                Console.WriteLine("Неверные значения.");
            }

            Console.WriteLine("Хотите продолжить(да или нет): ");
            string con = Console.ReadLine();
            if (con.ToLower() != "да")
            {
                break;
            }
        }
    }
}
