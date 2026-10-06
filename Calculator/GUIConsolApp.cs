using System;
using System.Collections.Generic;

namespace Calc
{
    public class GUIConsolApp
    {
        public void Start()
        {
            Math clsmath = new Math();
            ArrayMath clsarray = new ArrayMath();

            while (true)
            {
                Console.WriteLine($"\n----------------------\n" +
                    $"+ (Плюс)\n" +
                    $"- (Минус)\n" +
                    $"* (Умножить)\n" +
                    $"/ (Разделить)\n" +
                    $"! (Факториал)\n" +
                    $"mod (Остаток от деления)\n" +
                    $"% (Процент)\n" +
                    $"d% (dPercent)\n" +
                    $"sum (Сумма)\n" +
                    $"count (Количество)\n" +
                    $"max (Максимум)\n" +
                    $"min (Минимум)\n" +
                    $"sortasc (возрастание)\n" +
                    $"sortdesc (убывание)\n" +
                    $"stop - Закончить действие\n" +
                    $"exit - Выход\n");
                Console.Write("Выберите действие (введи знак): ");

                string choice = Console.ReadLine();

                if (choice == "exit" || choice == "0")
                {
                    break;
                }

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

                            if (double.TryParse(input, out double validNumber))
                            {
                                numbers.Add(validNumber);
                            }
                            else
                            {
                                Console.WriteLine("Ошибка! Введите число.");
                            }
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
                        int n;
                        while (true)
                        {
                            Console.Write("Введи целое число: ");
                            string input = Console.ReadLine();
                            if (int.TryParse(input, out n))
                            {
                                break;
                            }
                            Console.WriteLine("Ошибка! Введите целое число.");
                        }
                        Console.WriteLine("Факториал: " + clsmath.Factorial(n));
                        break;

                    case "mod":
                        double modA, modB;
                        while (true)
                        {
                            Console.Write("Введи число: ");
                            string inputA = Console.ReadLine();
                            if (double.TryParse(inputA, out modA))
                            {
                                break;
                            }
                            Console.WriteLine("Ошибка! Введите число.");
                        }
                        while (true)
                        {
                            Console.Write("Введи делитель: ");
                            string inputB = Console.ReadLine();
                            if (double.TryParse(inputB, out modB))
                            {
                                break;
                            }
                            Console.WriteLine("Ошибка! Введите число.");
                        }
                        Console.WriteLine("Остаток: " + clsmath.Mod(modA, modB));
                        break;

                    case "%":
                        double num, pct;
                        while (true)
                        {
                            Console.Write("Введи число: ");
                            string inputNum = Console.ReadLine();
                            if (double.TryParse(inputNum, out num))
                            {
                                break;
                            }
                            Console.WriteLine("Ошибка! Введите число.");
                        }
                        while (true)
                        {
                            Console.Write("Введи процент: ");
                            string inputPct = Console.ReadLine();
                            if (double.TryParse(inputPct, out pct))
                            {
                                break;
                            }
                            Console.WriteLine("Ошибка! Введите число.");
                        }
                        Console.WriteLine("Результат: " + clsmath.Percent(num, pct));
                        break;

                    case "d%":
                        double start, end;
                        while (true)
                        {
                            Console.Write("Начальное значение: ");
                            string inputStart = Console.ReadLine();
                            if (double.TryParse(inputStart, out start))
                            {
                                break;
                            }
                            Console.WriteLine("Ошибка! Введите число.");
                        }
                        while (true)
                        {
                            Console.Write("Конечное значение: ");
                            string inputEnd = Console.ReadLine();
                            if (double.TryParse(inputEnd, out end))
                            {
                                break;
                            }
                            Console.WriteLine("Ошибка! Введите число.");
                        }
                        Console.WriteLine("Изменение: " + clsmath.DPercent(start, end) + "%");
                        break;

                    case "sum":
                    case "count":
                    case "max":
                    case "min":
                    case "sortasc":
                    case "sortdesc":
                        List<double> List = new List<double>();
                        while (true)
                        {
                            Console.Write("Число: ");
                            string input = Console.ReadLine();
                            if (input == "stop")
                            {
                                break;
                            }

                            if (double.TryParse(input, out double validNumber))
                            {
                                List.Add(validNumber);
                            }
                            else
                            {
                                Console.WriteLine("Ошибка! Введите число.");
                            }
                        }

                        if (List.Count > 0)
                        {
                            double[] array = List.ToArray();
                            if (choice == "sum") Console.WriteLine("Sum: " + clsarray.Sum(array));
                            if (choice == "count") Console.WriteLine("Count: " + clsarray.Count(array));
                            if (choice == "max") Console.WriteLine("Max: " + clsarray.Max(array));
                            if (choice == "min") Console.WriteLine("Min: " + clsarray.Min(array));

                            if (choice == "sortasc")
                            {
                                double[] sorted = clsarray.SortAsc(array);
                                foreach (var x in sorted)
                                {
                                    Console.Write(x + " ");
                                }
                                Console.WriteLine();
                            }

                            if (choice == "sortdesc")
                            {
                                double[] sorted = clsarray.SortDesc(array);
                                foreach (var x in sorted)
                                {
                                    Console.Write(x + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                }
            }
        }
    }
}
