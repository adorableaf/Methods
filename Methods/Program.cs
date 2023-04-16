using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Stringer(string Symbol, int Amount)
        {
            for (int i = 0; i <= Amount; i++)
            {
                Console.Write(Symbol);
            }
            return;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите символ, который хотите использовать в строке:\t");
            string Symbol = Console.ReadLine();

            Console.Write("Введите желаемое количество символов в строке:\t");
            int Amount = int.Parse(Console.ReadLine());

            Stringer(Symbol, Amount);

            Console.ReadLine();

        }
    }
}
