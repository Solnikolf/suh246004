using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырёхзначное число: ");
            var n = int.Parse(Console.ReadLine());

            var d1 = n / 1000;
            var d2 = (n / 100) % 10;
            var d3 = (n / 10) % 10;
            var d4 = n % 10;

            var result = d3 * 1000 + d1 * 100 + d2 * 10 + d4;

            Console.WriteLine("Результат: " + result);
        }

    }
}