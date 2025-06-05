using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46_5
{
    internal class Accauntant
    {
        public enum Post
        {
            User, Manager, Tester, Director
        }
        public bool AskForBonus(Post worker, int hours)
        {
            if (hours >= 200)
            {
                Console.WriteLine($"Работник {worker} получает премию.");
                return true;
            }
            else
            {
                Console.WriteLine($"Работник {worker} не получает премию.");
                return false;
            }
        }
    }
}
