using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            double firstN = 0, secondN = 0;
            string operatorInput = inpOperator();
            inpNumber(ref firstN, ref secondN);
            double res = calc(firstN, secondN, operatorInput);

            if (res != double.NaN)
            {
                Console.WriteLine($"Результат: {res}");
            }

            Console.WriteLine("Хотите продолжить(да или нет): ");
            string con = Console.ReadLine();
            if (con.ToLower() != "да")
            {
                break;
            }
        }
    }

    static void inpNumber(ref double firstN, ref double secondN)
    {
        Console.WriteLine("Введите первое число: ");
        double.TryParse(Console.ReadLine(), out firstN);
        Console.WriteLine("Введите второе число: ");
        double.TryParse(Console.ReadLine(), out secondN);
    }

    static string inpOperator()
    {
        string operatorInput;
        while (true)
        {
            Console.WriteLine("Введите оператор (+, -, *, /): ");
            operatorInput = Console.ReadLine();
            if (operatorInput == "+" || operatorInput == "-" || operatorInput == "*" || operatorInput == "/")
            {
                break;
            }
            Console.WriteLine("Введен не верный оператор. Повторите попытку.");
        }
        return operatorInput;
    }

    static double calc(double firstN, double secondN, string operatorInput)
    {
        double res = double.NaN; 
        switch (operatorInput)
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
                }
                else
                {
                    res = firstN / secondN;
                }
                break;
            default:
                Console.WriteLine("Неверный оператор.");
                break;
        }
        return res;
    }
}
