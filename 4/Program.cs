using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int White = 1, Black = 1, N;
            bool parse = false, condition = true;
            while (condition)
            {
                Console.WriteLine("Введите колличество белых мышей");
                parse = Int32.TryParse(Console.ReadLine(), out White);
                if (White > 0 && parse == true)
                {
                    condition = false;
                }
            }
            condition = true;
            while (condition)
            {
                Console.WriteLine("Введите колличество черных мышей");
                parse = Int32.TryParse(Console.ReadLine(), out Black);
                if (Black > 0 && parse == true)
                {
                    condition = false;
                }
            }
            N = (White + 1) * Black + White;
            Console.WriteLine($"Колличество ходов: {N}");
        }
    }
}
