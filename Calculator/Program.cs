using Calculator;
using System;
using System.Collections.Generic;

namespace Calc
{
    public class Program
    {
        static void Main()
        {
            Math clsmath = new Math();
            GUIConsolApp clsGUIConsolApp = new GUIConsolApp();

            while (true)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("+ (Плюс), - (Минус), * (Умножить), / (Разделить)");
                Console.WriteLine("! (Факториал), mod (Остаток от деления), % (Процент), d% (dPercent)");
                Console.WriteLine("sum (Сумма), count (Количество), max (Максимум), min (Минимум)");
                Console.WriteLine("0 или exit - Выход");
                Console.Write("Выбери действие (введи знак): ");

                string choice = Console.ReadLine();

                if (choice == "exit" || choice == "0")
                {
                    break;
                }
                    #region MathEnter

                switch (choice)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        List<double> numbers = new List<double>();

                        while (true)
                        {
                            Console.Write("Число: ");
                            string input = Console.ReadLine();

                            if (input == "stop")
                            {
                                break;
                            }

                            numbers.Add(Convert.ToDouble(input));
                        }

                        if (numbers.Count > 0)
                        {
                            double result = numbers[0];

                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (choice == "+") result = clsmath.Add(result, numbers[i]);
                                if (choice == "-") result = clsmath.Subtract(result, numbers[i]);
                                if (choice == "*") result = clsmath.Multipy(result, numbers[i]);
                                if (choice == "/") result = clsmath.Divide(result, numbers[i]);
                            }

                            Console.WriteLine("Результат: " + result);
                        }
                        break;

                    case "!":
                        Console.Write("Введи целое число: ");
                        int fac = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Факториал: " + clsmath.Factorial(fac));
                        break;

                    case "mod":
                        Console.Write("Введите число: ");
                        double modA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите делитель: ");
                        double modB = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Остаток: " + clsmath.Mod(modA, modB));
                        break;

                    case "%":
                        Console.Write("Введи число: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введи процент: ");
                        double pct = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: " + clsmath.Percent(num, pct));
                        break;

                    case "d%":
                        Console.Write("Начальное значение: ");
                        double start = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Конечное значение: ");
                        double end = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Изменение: " + clsmath.DPercent(start, end) + "%");
                        break;
                #endregion
                    #region ArrayEnter

                    case "sum":
                    case "count":
                    case "max":
                    case "min":
                   
                        List<double> List = new List<double>();
                        while (true)
                        {
                            Console.Write("Число: ");
                            string input = Console.ReadLine();
                            if (input == "stop")
                            {
                                break;
                            }
                            List.Add(Convert.ToDouble(input));
                        }

                        if (List.Count > 0)
                        {
                            double[] array = List.ToArray();
                            if (choice == "sum") Console.WriteLine("Sum: " + clsGUIConsolApp.Sum(array));
                            if (choice == "count") Console.WriteLine("Count: " + clsGUIConsolApp.Count(array));
                            if (choice == "max") Console.WriteLine("Max: " + clsGUIConsolApp.Max(array));
                            if (choice == "min") Console.WriteLine("Min: " + clsGUIConsolApp.Min(array));
                        }
                        break;
                    #endregion
                }
            }
        }
    }
}
