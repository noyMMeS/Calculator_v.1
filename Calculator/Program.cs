using System;

namespace Calc
{

    class Program
    {
        static void Main()
        {
            Calc c = new Calc();
            ArrayCalc ac = new ArrayCalc();

            while (true)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("1 - Плюс (+), 2 - Минус (-), 3 - Умножить (*), 4 - Разделить (/)");
                Console.WriteLine("5 - Факториал (!), 6 - Остаток от деления (%), 7 - Процент, 8 - dPercent");
                Console.WriteLine("9 - Работа с массивом (ввод чисел по очереди)");
                Console.WriteLine("0 - Выход");
                Console.Write("Выбери действие: ");
                

                string choice = Console.ReadLine();


                if (choice == "0" || choice == "exit")
                {
                    break;
                }

               
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    Console.Write("Введи первое число: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введи второе число: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    if (choice == "1") Console.WriteLine("Результат: " + c.Add(a, b));
                    if (choice == "2") Console.WriteLine("Результат: " + c.Subtract(a, b));
                    if (choice == "3") Console.WriteLine("Результат: " + c.Multipy(a, b));
                    if (choice == "4") Console.WriteLine("Результат: " + c.Divide(a, b));
                }
                
                else if (choice == "5")
                {
                    Console.Write("Введи целое число: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Факториал: " + c.Factorial(n));
                }
                
                else if (choice == "6")
                {
                    Console.Write("Введи число: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введи делитель: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Остаток: " + c.Mod(a, b));
                }
                
                else if (choice == "7")
                {
                    Console.Write("Введи число: ");
                    double num = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введи процент: ");
                    double pct = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат: " + c.Percent(num, pct));
                }
                
                else if (choice == "8")
                {
                    Console.Write("Начальное значение: ");
                    double start = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Конечное значение: ");
                    double end = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Изменение: " + c.DPercent(start, end) + "%");
                }
                
                else if (choice == "9")
                {
                    List<double> list = new List<double>();
                    Console.WriteLine("Вводи числа по одному. Чтобы закончить, напиши 'stop':");

                    while (true)
                    {
                        Console.Write("Число: ");
                        string input = Console.ReadLine();

                        if (input == "stop")
                        {
                            break;
                        }

                        list.Add(Convert.ToDouble(input));
                    }

                    if (list.Count > 0)
                    {
                        double[] array = list.ToArray();
                        Console.WriteLine("Sum: " + ac.Sum(array));
                        Console.WriteLine("Count: " + ac.Count(array));
                        Console.WriteLine("Max: " + ac.Max(array));
                        Console.WriteLine("Min: " + ac.Min(array));
                    }
                    else
                    {
                        Console.WriteLine("Массив пуст.");
                    }
                }
            }
        }
    }
}