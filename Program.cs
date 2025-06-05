using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    enum Months
    {
        январь, февраль, март, апрель, май, июнь, июль, август, сентябрь, октябрь, ноябрь, декабрь
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Months i;
            for (i = Months.январь; i<= Months.декабрь; i++)
            {
                Console.WriteLine($"{(int)i} {i}");
            }
            Console.Read();
        }
    }
}
