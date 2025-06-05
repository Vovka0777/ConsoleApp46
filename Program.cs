using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();
            Accauntant.Post i;
            bool flag = true;
            int hours = 0;
            while (flag)
            {
                Console.WriteLine($"Выберите роль работника ({Accauntant.Post.User}, {Accauntant.Post.Manager}, {Accauntant.Post.Tester}, {Accauntant.Post.Director}):");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "User":
                        Console.Clear();
                        i = Accauntant.Post.User;
                        Console.Write("Введите количество отработанных часов: ");
                        hours = int.Parse(Console.ReadLine());
                        accauntant.AskForBonus(i, hours);
                        Console.WriteLine();
                        break;
                    case "Manager":
                        Console.Clear();
                        i = Accauntant.Post.Manager;
                        Console.Write("Введите количество отработанных часов: ");
                        hours = int.Parse(Console.ReadLine());
                        accauntant.AskForBonus(i, hours);
                        Console.WriteLine();
                        break;
                    case "Tester":
                        Console.Clear();
                        i = Accauntant.Post.Tester;
                        Console.Write("Введите количество отработанных часов: ");
                        hours = int.Parse(Console.ReadLine());
                        accauntant.AskForBonus(i, hours);
                        Console.WriteLine();
                        break;
                    case "Director":
                        Console.Clear();
                        i = Accauntant.Post.Director;
                        Console.Write("Введите количество отработанных часов: ");
                        hours = int.Parse(Console.ReadLine());
                        accauntant.AskForBonus(i, hours);
                        Console.WriteLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
