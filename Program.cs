using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46_4
{
    enum UserRole
    {
        Администратор, Модератор, Пользователь, Гость
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine($@"Выберите роль пользователя:
1. {UserRole.Администратор}
2. {UserRole.Модератор}
3. {UserRole.Пользователь}
4. {UserRole.Гость}
5. Выход");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"Вы зарегестрированы как {UserRole.Администратор}");
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"Вы зарегестрированы как {UserRole.Модератор}"); Console.WriteLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine($"Вы зарегестрированы как {UserRole.Пользователь}"); Console.WriteLine();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine($"Вы зарегестрированы как {UserRole.Гость}"); Console.WriteLine();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Выход из программы.");
                       flag = false; 
                        Console.Read();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный выбор, попробуйте еще раз."); Console.WriteLine();
                        break;
                }
            }
        }
    }
}
