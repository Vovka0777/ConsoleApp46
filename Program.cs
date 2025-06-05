using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46_3
{
    enum Maths
    {
        plus = 1, minus, multiply, divide
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths i;
            bool s = true;
            
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            while (s)
            {
                Console.WriteLine(@"Введите номер операции: 
1 - сложение, 
2 - вычитание, 
3 - умножение, 
4 - деление,
0 - выход");
                string ss = Console.ReadLine();
                switch (ss)
                {
                    case "1":
                        Console.Clear();
                        i = Maths.plus;
                        Console.WriteLine($"Вы выбрали операцию: {i} с номером {(int)i}");
                        Console.WriteLine($"a + b = {a} + {b} = {a + b}");
                        break;
                    case "2":
                        Console.Clear();
                        i = Maths.minus;
                        Console.WriteLine($"Вы выбрали операцию: {i} с номером {(int)i}");
                        Console.WriteLine($"a - b = {a} - {b} = {a - b}");
                        break;
                    case "3":
                        Console.Clear();
                        i = Maths.multiply;
                        Console.WriteLine($"Вы выбрали операцию: {i} с номером {(int)i}");
                        Console.WriteLine($"a * b = {a} * {b} = {a * b}");
                        break;
                    case "4":
                        i = Maths.divide;
                        if (b == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Деление на ноль невозможно!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Вы выбрали операцию: {i} с номером {(int)i}");
                            Console.WriteLine($"a / b = {a} / {b} = {a / b}");
                        }
                        break;
                    case "0":
                        {
                            Console.Clear();
                            Console.WriteLine("Выход из программы.");
                            s = false;
                            break;
                        }
                }
            }

        }
    }
}
